using LenaSoftware.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaSoftware.Core.Entities.Concrete
{
    public class BaseEntity : ICreatableEntity
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; } 
    }
}
