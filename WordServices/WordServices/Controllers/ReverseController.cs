using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WordServices.Utils;

namespace WordServices.Controllers
{
    public class ReverseController : ApiController{
        [HttpGet]
        public string Get(string word) => WordUtils.Reverser(word);
    }
}
