using System;
using BLL.Services;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodHut.Controllers
{
    public class FoodController : ApiController
    {
        [HttpGet]
        [Route("api/fooddelivary")]
        public HttpResponseMessage FoodDelivary()
        {
            try
            {
                var data = FoodDelivaryService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }



        [HttpGet]
        [Route("api/fooddelivary/{id}")]



        public HttpResponseMessage FoodDelivary(int id)
        {
            try
            {
                var data = FoodDelivaryService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }



        [HttpGet]
        [Route("api/fooddelivary/{id}/orders")]



        public HttpResponseMessage FoodsDelivary(int id)
        {
            try
            {
                var data = FoodDelivaryService.GetWithOrder(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }

        }
    }
}
