using Asp.Versioning;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using RentAVilla_VillaAPI.Data;

using RentAVilla_VillaAPI.Models;
using RentAVilla_VillaAPI.Models.Dto;
using RentAVilla_VillaAPI.Repository.RepositoryInterfaces;
using System.Net;

namespace RentAVilla_VillaAPI.Controllers.v2
{
    // We can also use [Route("api/[controller]")] to use the controller name as the route]
    [Route("api/v{version:apiVersion}/villaNumberAPI")]
    [ApiController]
    [ApiVersion("2.0")]
    public class VillaNumberAPIv2Controller : ControllerBase
    {
        protected APIResponse _response;
        private readonly IVillaNumberRepository _dbVillaNumber;
        private readonly IVillaRepository _dbVilla;
        private readonly IMapper _mapper;
        public VillaNumberAPIv2Controller(IVillaNumberRepository dbVillaNumber, IMapper mapper,
            IVillaRepository dbVilla)
        {
            _dbVillaNumber = dbVillaNumber;
            _mapper = mapper;
            _response = new();
            _dbVilla = dbVilla;
        }


        [HttpGet("GetString")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


    }

}
