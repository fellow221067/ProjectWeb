using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem.Models
{
    public class ClassModel
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "Only 50 characters are allowed.")]
        public string Name { get; set; }
    }
}
