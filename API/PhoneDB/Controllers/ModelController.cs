using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PhoneDB.Repositories;
using PhoneDB.Models;

namespace PhoneDB.Controllers
{
    public class ModelController : ApiController
    {
        public ModelRepository modelRepository = new ModelRepository();
        [HttpGet()]
        public IEnumerable<Model> GetAll()
        {
            return modelRepository.GetAll();
        }
    }
}
