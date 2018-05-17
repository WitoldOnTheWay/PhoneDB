using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PhoneDB.Repositories;
using PhoneDB.Models;

namespace PhoneDB.Controllers
{
    public class ManufacturerController : ApiController
    {
        public ManufacturerRepository manufacturerRepository = new ManufacturerRepository();
        [HttpGet()]
        public IEnumerable<Manufacturer> GetAll()
        {
            return manufacturerRepository.GetAll();
        }
    }
}
