using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartH2RCore.Models.DTO.Settings;
using SmartH2RCore.Services.Interface;
using System.Threading.Tasks;
using System;
using SmartH2RCore.Services.Service;
using SmartH2RCore.Models.DTO.Master;
using SmartH2RCore.Models.Common;
using System.Linq;

namespace SmartH2RCore.Web.Controllers
{
    public class ChangePasswordController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IChangePasswordService _ChangePasswordService;

        public ChangePasswordController(IChangePasswordService ChangePasswordService, IMapper mapper)
        {
            _ChangePasswordService = ChangePasswordService;
            _mapper = mapper;
        }

        [Route("ChangePassword")]
        public IActionResult ChangePassword()
        {
            var ChangePassword = _ChangePasswordService.GetAll().FirstOrDefault();
            return View(_mapper.Map<ChangePasswordDTO>(ChangePassword));

        }
        [Route("ChangePassword"), HttpPost]

        public async Task<IActionResult> ChangePassword(ChangePasswordDTO settingDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (settingDTO.Id > 0)
                    {
                        await _ChangePasswordService.UpdateAsync(_mapper.Map<ChangePassword>(settingDTO));
                        TempData["Message"] = "ChangePassword Updated Successfully!";
                    }
                    else
                    {
                        await _ChangePasswordService.AddAsync(_mapper.Map<ChangePassword>(settingDTO));
                        TempData["Message"] = "ChangePassword not updated Successfully!";
                    }

                    TempData["Success"] = true;
                    return View(settingDTO);
                }
                catch (Exception ex)
                {
                    TempData["Message"] = ex.Message;
                    TempData["Success"] = false;
                    return View(settingDTO);
                }
            }
            return View(settingDTO);
        }
    }
}
