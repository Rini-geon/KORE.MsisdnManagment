using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MsisdnManagmentService.Controllers
{
    [Route("api/[controller]")]
    
    public class MsisdnActivationController : Controller
    {
        [HttpGet("get_msisdn")]
        public IEnumerable<string> getMsisdn()
        {
            return new string[]{"1201","1202","1203"};
        }
    }
}