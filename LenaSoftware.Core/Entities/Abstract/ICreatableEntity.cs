﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaSoftware.Core.Entities.Abstract
{
    public interface ICreatableEntity:IEntity
    {
        int CreatedBy { get; set; }
        DateTime CreatedTime { get; set; }
    }
}
