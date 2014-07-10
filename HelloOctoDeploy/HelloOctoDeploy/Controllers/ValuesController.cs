using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace HelloOctoDeploy.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public ResponseObject Get()
        {
            var appSettings = ConfigurationManager.AppSettings.Get("DeployedVersion");
            return new ResponseObject() { BuildNumber = appSettings };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public class ResponseObject
    {
        [JsonProperty("buildNumber")]
        public string BuildNumber { get; set; }
    }
}
