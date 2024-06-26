using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentAVilla_Utility;
using RentAVilla_Web.Models;
using RentAVilla_Web.Models.Dto;
using RentAVilla_Web.Services.IServices;
using System.Diagnostics;

namespace RentAVilla_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;
        public HomeController(IVillaService villaService, IMapper mapper)
        {
            _villaService = villaService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            List<VillaDTO> list = new();

            var response = await _villaService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
            }
            return View(list);
        }

    }
}
