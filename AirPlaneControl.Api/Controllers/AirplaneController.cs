using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AirplaneControl.Domain;
using AirplaneControl.Domain.Common;
using AirPlaneControl.Api.ViewModel;
using AirpPlaneControl.Service;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirPlaneControl.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class AirplaneController : ControllerBase
    {
        private readonly IAirplaneService _airplaneService;
       private readonly IMapper _mapper;

        public AirplaneController(IAirplaneService airplaneService, IMapper mapper)
        {
            _airplaneService = airplaneService;
           _mapper = mapper;
        }
       [HttpGet]
        [Route("GetAllAirplane")]
        public ActionResult<IList<AirPlaneVM>> GetAll()
        {
            var result = _airplaneService.GetAll().ToList();

            List<AirPlaneVM> obj = _mapper.Map<List<AirPlaneVM>>(result);
            return obj;
        }

        [HttpGet]
        [Route("FindAirplane")]
        public ActionResult<AirPlaneVM> GetById(int id)
        {
            var result = _airplaneService.Get(id);
            var obj = _mapper.Map<AirPlaneVM>(result);
            return obj;
        }

      
        [HttpPost]
        [Route("InsertAirplane")]
        public Result<Airplane> Post(AirPlaneVM request)
        {
            var obj = _mapper.Map<Airplane>(request);
            var r = _airplaneService.Insert(obj);
            return r;
        }


    }
}