﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Response
{
    public class GetUserResponse
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Avatar {  get; set; }
    }
}
