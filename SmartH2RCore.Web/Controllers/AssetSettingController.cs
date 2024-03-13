using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartH2RCore.Models.DTO.Master;
using SmartH2RCore.Services.Interface;
using SmartH2RCore.Services.Service;
using System.Threading.Tasks;
using System;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.DTO.Settings;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SmartH2RCore.Web.Controllers
{
    public class AssetSettingController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IAssetSettingService _assetSettingService;

        public AssetSettingController(IAssetSettingService assetSettingService, IMapper mapper)
        {
            _assetSettingService = assetSettingService;
            _mapper = mapper;
        }

        [Route("assetSetting")]
        public IActionResult AssetSetting()
        {
            var assetSetting = _assetSettingService.GetAll().FirstOrDefault();
            return View(_mapper.Map<AssetSettingDTO>(assetSetting));

        }
        [Route("assetSetting"), HttpPost]

        public async Task<IActionResult> AssetSetting(AssetSettingDTO settingDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (settingDTO.Id > 0)
                    {
                        await _assetSettingService.UpdateAsync(_mapper.Map<AssetSetting>(settingDTO));
                        TempData["Message"] = "assetSetting Updated Successfully!";
                    }
                    else
                    {
                        await _assetSettingService.AddAsync(_mapper.Map<AssetSetting>(settingDTO));
                        TempData["Message"] = "assetSetting not  Successfully!";
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
