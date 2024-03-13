using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using SmartH2RCore.Models.DTO.Settings;
using SmartH2RCore.Services.Interface;
using SmartH2RCore.Services.Service;
using System.Threading.Tasks;
using System;
using SmartH2RCore.Models.Common;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Razor.Language;
using System.Collections.Generic;



namespace SmartH2RCore.Web.Controllers
{
    public class ThemeSettingsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IThemeSettingsService _themeSettingsService;

        public ThemeSettingsController(IThemeSettingsService themeSettingService, IMapper mapper)
        {
            _themeSettingsService = themeSettingService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("ThemeSettings")]
        public IActionResult ThemeSettings()
        {
            var themeSettings = _themeSettingsService.GetAll().FirstOrDefault();
            var themeSettingsDTO = _mapper.Map<ThemeSettingsDTO>(themeSettings);
            return View(themeSettingsDTO);
        }

        [HttpPost]
        [Route("ThemeSettings")]
        public async Task<IActionResult> ThemeSettings(ThemeSettingsDTO settingDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (settingDTO.Id > 0)
                    {
                        await _themeSettingsService.UpdateAsync(_mapper.Map<ThemeSettings>(settingDTO));
                        TempData["Message"] = "Theme Settings Updated Successfully!";
                    }
                    else
                    {
                        await _themeSettingsService.AddAsync(_mapper.Map<ThemeSettings>(settingDTO));
                        TempData["Message"] = "Theme Settings added Successfully!";
                    }

                    // Reset the CompanyName after saving
                    settingDTO.CompanyName = null;
                    TempData["Success"] = true;

                    // Return a new instance to the view
                    return View(new ThemeSettingsDTO());
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
