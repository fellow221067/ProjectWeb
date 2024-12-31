using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagmentSystem.Models
{
    public class RoleModel
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "Only 50 characters are allowed.")]
        public string Name { get; set; }
    }
}
