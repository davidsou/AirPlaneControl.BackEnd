using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
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
       // private Expression<Func<T, object>> _defaultOrder = x => x.Id;

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

            List<AirPlaneVM> teste =  _mapper.Map<List<AirPlaneVM>>(result);
            return teste;
        }

        [HttpGet]
        [Route("FindAirplane")]
        public ActionResult<AirPlaneVM> GetById(int id)
        {
            return new AirPlaneVM { Name = "Teste01", QuantityOfSeats = 50 };
        }

        // POST api/values
        [HttpPost]
        [Route("InsertAirplane")]
        public void Post([FromBody] string value)
        {
        }


    }
}