using System;
using System.Collections.Generic;
using System.Linq;
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
    public class PassengerController : ControllerBase
    {
        private readonly IPassengerService _passengerService;
        private readonly IMapper _mapper;
        public PassengerController(IPassengerService passengerService, IMapper mapper)
        {
            _mapper = mapper;
            _passengerService = passengerService;
        }


        //[HttpGet]
        //[Route("ListAllPassangerByAirplane")]
        //public ActionResult<PassengerVM> GetById(int id)
        //{
        //    var result = _passengerService.Get(id);
        //    var obj = _mapper.Map<PassengerVM>(result);
        //    return obj;
        //}


        [HttpPost]
        [Route("InsertPassenger")]
        public Result<Passenger> Post(PassengerVM request)
        {
            var obj = _mapper.Map<Passenger>(request);
            var r = _passengerService.Insert(obj);
            return r;
        }

        [HttpPost]
        [Route("InsertPassengerToAirplane")]
        public Result<Passenger> InsertPassangerToAirplane(PassengerToAirplaneVM request)
        {
            var obj = _mapper.Map<PassengerToAirPlane>(request);
            var r = _passengerService.PassengerToAirPlane(obj);
            return r;
        }

        [HttpPut]
        [Route("ChangePassenger")]
        public Result<Passenger> ChangePassengerAirplane(PassengerToAirplaneVM request)
        {
            var obj = _mapper.Map<PassengerToAirPlane>(request);
            var r = _passengerService.ChangePassanger(obj);
            return r;
        }



    }
}