using AutoMapper;
using JqueryDataTables.ServerSide.AspNetCoreWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.DTO;
using SmartH2RCore.Models.DTO.EmployeeDTO;
using SmartH2RCore.Models.DTO.Master;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Models.Identity;
using SmartH2RCore.Services.Interface.Employee;
using SmartH2RCore.Services.Service.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;



namespace SmartH2RCore.Web.Controllers
{
    public class JobDetailsController : BaseController

    {
        private readonly IMapper _mapper;
        private readonly IJobDetailsService _jobDetailsService;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public JobDetailsController(IJobDetailsService jobDetailsService, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _jobDetailsService = jobDetailsService;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;

        }


        [Route("JobDetailsCon")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("List", new JobDetailsDTO());
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }
        public IActionResult Add(SignupModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.Email,
                    Email = model.Email,

                };
                var result = _userManager.CreateAsync(user, model.Password).Result;
                if (result.Succeeded)
                {
                    _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }

                return View(model);
            }

            IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
            ModelState.AddModelError(string.Empty, allErrors.FirstOrDefault().ErrorMessage);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(JobDetailsDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _jobDetailsService.AddAsync(_mapper.Map<JobDetails>(model));
                    TempData["Message"] = "Jobdetails Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "JobDetailsCon");
                }
                catch (Exception ex)
                {
                    TempData["Message"] = ex.Message;
                    TempData["Success"] = false;
                    return View("Add", model);
                }
            }
            return View("Add", model);
        }
        //[HttpGet]
        //public async Task<IActionResult> GetJobdetails(int companyId,int BranchId,int DepartmentId)
        //{
        //    var jobdetail = await _jobDetailsService.GetAll().Where(v => v.CompanyId == companyId).Select(v => new { v.Id, v.BranchId }).ToListAsync();
        //    return new JsonResult(jobdetail);
        //}
        [HttpGet]

        public async Task<IActionResult> GetJobdetail(int BranchId)
        {
            var jobdtl = await _jobDetailsService.GetAll().Where(v => v.BranchId == BranchId).Select(v => new { v.Id, v.BranchId }).ToListAsync();
            return new JsonResult(jobdtl);
        }
        [HttpGet]
        public async Task<IActionResult> GetDepatment(int DepartmentId)
        {
            var Department = await _jobDetailsService.GetAll().Where(v => v.DepartmentId == DepartmentId).Select(v => new { v.Id, v.DepartmentId }).ToListAsync();
            return new JsonResult(Department);
        }
        [HttpGet]
        public async Task<IActionResult> GetAlluser()
        {
            var user = await _jobDetailsService.GetAll().Select(d => new { d.Employee.Id }).ToListAsync();
            return new JsonResult(user);
        }

        #region Use for Datatable
        [HttpPost]
        public async Task<IActionResult> GetJobDetailes([FromBody] JqueryDataTablesParameters param)
        {
            try
            {
                var result = await _jobDetailsService.GetJobDetailes(param, LoginUser.Id);
                HttpContext.Session.SetString(nameof(JqueryDataTablesParameters), JsonSerializer.Serialize(param));
                return new JsonResult(new JqueryDataTablesResult<JobDetailsDTO>
                {
                    Draw = param.Draw,
                    Data = result.Items.ToArray(),
                    RecordsFiltered = result.TotalSize,
                    RecordsTotal = result.TotalSize
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new { error = e.Message });
            }
        }
        #endregion
    }
}
