using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CamCardMock.Controllers
{
    public class CamCardMockController : ApiController
    {
        // GET: api/CamCardMock
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CamCardMock/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CamCardMock
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CamCardMock/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CamCardMock/5
        public void Delete(int id)
        {
        }
    }
}
