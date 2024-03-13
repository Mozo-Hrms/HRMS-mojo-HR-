using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.DTO.Master;
using SmartH2RCore.Models.DTO.Settings;
using SmartH2RCore.Services.Interface;
using SmartH2RCore.Services.Service;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SmartH2RCore.Web.Controllers
{
    public class LocalizationController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly ILocalizationSettingService _localizationSettingService;

        public LocalizationController(ILocalizationSettingService localizationSettingService, IMapper mapper)
        {
            _localizationSettingService = localizationSettingService;
            _mapper = mapper;
        }

        [Route("localization")]
        public IActionResult LocalizationSetting()
        {
            var localization = _localizationSettingService.GetAll().FirstOrDefault();
            return View(_mapper.Map<LocalizatonSettingDTO>(localization));
            
        }
        [Route("localization"),HttpPost]
        
        public async Task<IActionResult> LocalizationSetting(LocalizatonSettingDTO settingDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (settingDTO.Id > 0)
                    {
                        await _localizationSettingService.UpdateAsync(_mapper.Map<LocalizationSetting>(settingDTO));
                        TempData["Message"] = "Localization Setting Updated Successfully!";
                    }
                    else
                    {
                        await _localizationSettingService.AddAsync(_mapper.Map<LocalizationSetting>(settingDTO));
                        TempData["Message"] = "Localization not  Successfully!";
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
    

