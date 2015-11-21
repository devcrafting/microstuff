using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MicroStuff.Sessions.Data;
using MicroStuff.Sessions.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroStuff.Sessions.Controllers
{
    [Route("sessions")]
    public class SessionsController
    {
        private ISessions _sessions;

        public SessionsController(ISessions sessions){
            _sessions = sessions;
        }
        
        [HttpGet]
        public IList<Session> Get()
        {
            return _sessions.Get().ToList();
        }
    }
}
