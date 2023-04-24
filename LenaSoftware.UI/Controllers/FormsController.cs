using AutoMapper;
using LenaSoftware.Business.Services.Abstract;
using LenaSoftware.DataAccess.Context;
using LenaSoftware.Dto;
using LenaSoftware.Entities.DbSets;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LenaSoftware.UI.Controllers
{
    [Authorize(Roles = "User")]
    public class FormsController : Controller
    {
        private readonly IFormService _formService;
        private readonly IMapper _mapper;


        public FormsController(IFormService formService, IMapper mapper)
        {
            _formService = formService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll(string search)
        {

            if (!string.IsNullOrEmpty(search))
            {
                return View();
            }
            var list = _formService.GetAll();
            return View(list);
        }

        [HttpGet]
        public IActionResult CreateForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateForm(FormCreateDto formCreate)
        {
            if (!ModelState.IsValid)
            {
                return View(formCreate);
            }
            var newForm = _mapper.Map<Form>(formCreate); 
            _formService.Add(newForm);            
            return RedirectToAction("GetAll");
        }

        public IActionResult FormDetail(int id)
        {
            var formDetail = _formService.GetById(id);
            return View(formDetail);
        }
    }
}
