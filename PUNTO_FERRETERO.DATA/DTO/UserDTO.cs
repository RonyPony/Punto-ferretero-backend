﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;

namespace PUNTO_FERRETERO.DATA.DTO
{
    public class UserDTO
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
    }
}


