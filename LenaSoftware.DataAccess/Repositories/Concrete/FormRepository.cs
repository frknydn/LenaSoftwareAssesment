using LenaSoftware.Core.DataAccess.EF;
using LenaSoftware.Core.DataAccess.Interfaces;
using LenaSoftware.DataAccess.Context;
using LenaSoftware.DataAccess.Repositories.Abstract;
using LenaSoftware.Entities.DbSets;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaSoftware.DataAccess.Repositories.Concrete
{
    public class FormRepository : BaseRepository<Form>, IFormRepository
    {
        public FormRepository(LenaSoftwareDbContext context) : base(context)
        {

        }
    }
}
