using LenaSoftware.Core.Entities.Abstract;
using LenaSoftware.Dto;
using LenaSoftware.Entities.DbSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaSoftware.Business.Services.Abstract
{
    public interface IFormService
    {
        Form GetById(int id);
        List<Form> GetAll();
        Form Add(Form entity);
      
    }
}
