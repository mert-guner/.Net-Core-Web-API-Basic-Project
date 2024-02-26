using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrate;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IhotelService _hotelService;

        public HotelsController(IhotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        public List<Hotel> Get()
        {
            return _hotelService.GetAllHotels();
        }

        [HttpGet("{id}")]
        public Hotel Get(int id)
        {
            return _hotelService.GetHotelById(id);
        }

        [HttpPost]
        public Hotel Post([FromBody]Hotel hotel)
        {
            return _hotelService.CreateHotel(hotel);
        } 
        
        [HttpPut]
        public Hotel Put([FromBody]Hotel hotel)
        {
            return _hotelService.UpdateHotel(hotel);
        } 
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _hotelService.DeleteHotel(id);
        }
    }
}
