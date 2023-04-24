using LenaSoftware.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaSoftware.Core.Entities.Concrete
{
    public class BaseUser : IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        [Required(ErrorMessage = "Email boş bırakılamaz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre boş bırakılamaz")]
        public string Password { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
