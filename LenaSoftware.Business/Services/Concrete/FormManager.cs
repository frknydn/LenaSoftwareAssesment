using AutoMapper;
using LenaSoftware.Business.Services.Abstract;
using LenaSoftware.DataAccess.Repositories.Abstract;
using LenaSoftware.Dto;
using LenaSoftware.Entities.DbSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaSoftware.Business.Services.Concrete
{
    public class FormManager : IFormService
    {
        private readonly IFormRepository _formRepository;
        private readonly IMapper _mapper;
        public FormManager(IFormRepository formRepository, IMapper mapper)
        {
            _formRepository = formRepository;
            _mapper = mapper;
        }

        public Form Add(Form entity)
        {
            Form newForm = new Form
            {
                FormName = entity.FormName,
                Description = entity.Description,
                Name = entity.FormName,
                Surname = entity.Surname,
                Age = entity.Age,
                CreatedBy=1,
                CreatedTime = DateTime.Now,
                UserID=1
            };
            _formRepository.Add(newForm);
            return newForm;

        }

        public void Delete(Form entity)
        {
            throw new NotImplementedException();
        }

        public List<Form> GetAll()
        {
            return _formRepository.GetAll();
        }
       
        public Form GetById(int id)
        {
            return _formRepository.GetById(id);
        }

      
    }
}
