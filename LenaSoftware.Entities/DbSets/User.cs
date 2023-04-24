using LenaSoftware.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaSoftware.Entities.DbSets
{
    public class User : BaseUser
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Form> Forms { get; set; }
    }

}
