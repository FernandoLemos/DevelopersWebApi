using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;
using DevelopersWebApi.Model;

namespace DevelopersWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            using (StreamReader doc = new StreamReader(@"C:\Users\Fernando\source\repos\DevelopersWebApi\DevelopersWebApi\Datos\developers.json"))
            {
                string jsonDevelopers = doc.ReadToEnd();
                var developers = JsonConvert.DeserializeObject<List<Developer>>(jsonDevelopers);

                return Json(new {developers});
            }
              
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
