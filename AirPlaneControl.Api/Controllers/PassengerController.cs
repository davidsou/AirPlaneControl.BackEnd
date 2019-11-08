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
        public PassengerController()
        {

        }
        [HttpGet]
        [Route("ListAllPassangerByAirplane")]
        public ActionResult<IList<PassengerVM>> GetAll()
        {
            var result = _passengerService.GetAll().ToList();

            List<PassengerVM> obj = _mapper.Map<List<PassengerVM>>(result);
            return obj;
        }

        [HttpGet]
        [Route("ListAllPassangerByAirplane")]
        public ActionResult<PassengerVM> GetById(int id)
        {
            var result = _passengerService.Get(id);
            var obj = _mapper.Map<PassengerVM>(result);
            return obj;
        }


        [HttpPost]
        [Route("InsertPassanger")]
        public Result<Passenger> Post(PassengerVM request)
        {
            var obj = _mapper.Map<Passenger>(request);
            var r = _passengerService.Insert(obj);
            return r;
        }

        [HttpPost]
        [Route("InsertPassangerToAirplane")]
        public Result<Passenger> InsertPassangerToAirplane(PassengerVM request)
        {
            var obj = _mapper.Map<Passenger>(request);
            var r = _passengerService.Insert(obj);
            return r;
        }

        [HttpPut]
        [Route("ChangePassanger")]
        public Result<Passenger> InsertPassangerToAirplane(int id, int idAirplane)
        {
            //var obj = _mapper.Map<Passenger>(request);
            //var r = _passengerService.Insert(obj);
            return null;
        }

        //iii.ChangePassanger(int id, IdAirplane);


    }
}