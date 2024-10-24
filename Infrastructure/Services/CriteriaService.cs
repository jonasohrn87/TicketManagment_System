﻿using Domain.Entities;
using Domain.Interfaces;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CriteriaService : ICriteriaService
    {
        private readonly IUnitOfWork unitOfWork;

        public CriteriaService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public List<Category> GetCategories()
        {
            return unitOfWork.Repository<Category>().ListAll();
        }

        public List<Priority> GetPriority()
        {
            return unitOfWork.Repository<Priority>().ListAll();
        }

        public List<Product> GetProducts()
        {
            return unitOfWork.Repository<Product>().ListAll();
        }

        public List<string> GetStatus()
        {
            return new List<string>
            {
                "NEW",
                "OPEN",
                "CLOSED"
            };
        }
    }
}
