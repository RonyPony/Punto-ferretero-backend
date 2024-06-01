using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;

namespace PUNTO_FERRETERO.DATA.DTO
{
    internal class UserDTO
    {
        public Guid userId { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public DateTime updatedDate { get; set; }
    }
}


