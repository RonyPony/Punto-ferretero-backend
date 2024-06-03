using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_FERRETERO.DATA.MODELS
{
    public class Inventary
    {
        [Key]
        public Guid inventaryId { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }

    }
}
