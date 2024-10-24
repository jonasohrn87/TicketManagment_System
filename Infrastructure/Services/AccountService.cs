﻿using Domain.Interfaces;
using Domain.DTO.Request;
using Domain.DTO.Response;
using Microsoft.AspNetCore.Identity;
using Domain.Entities;
using Infrastructure.Common;

namespace Infrastructure.Services
{
    public class AccountService : IAccountService
    {
        private readonly SignInManager<User> signInmanager;
        public AccountService(SignInManager<User> signInManager)
        {
            signInmanager = signInManager;
        }
        public async Task<BaseResponse> RegisterUser(RegisterUserRequest request)
        {
            User user = new User
            {
                UserName = request.Email,
                Email = request.Email,
                AccountConfirmed = false
            };

            string password = Constants.DEFAULT_PASSWORD;

            var result = await signInmanager.UserManager.CreateAsync(user, password);
            return new BaseResponse
            {
                IsSuccess = result.Succeeded
            };
        }

        public async Task<BaseResponse<string>> VerifyUser(string email, string password)
        {
            BaseResponse<string> response = new();

            var user = await signInmanager.UserManager.FindByEmailAsync(email);
            if (user == null)
            {
                response.ErrorMessage = "User not found!";
                response.IsSuccess = false;
                return response;
            }

            var result = await signInmanager.UserManager.CheckPasswordAsync(user, password);
            response.IsSuccess = result;
            if (!result)
            {
                response.ErrorMessage = "Invalid Email / Password";
            }
            else
            {
                response.Value = user.UserName;
            }
            return response;

        }
    }
}