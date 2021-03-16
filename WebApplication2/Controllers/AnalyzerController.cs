using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading;

namespace WebApplication2.Controllers
{
    [Route("api/Analyzer/[controller]")]
    [ApiController]
    public class LedetectController : ControllerBase
    {
        private static GETiout _out = new GETiout();



        [HttpPost]
        public ObjectResult InPost(POSTin pOSTin)
        {
            if (pOSTin is null)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "dmskdms");
            }

            if (pOSTin.patient == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "dmskdms");
            }

            if (pOSTin.services == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "dmskdms");
            }

            Random random = new Random();

            _out = null;

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(random.Next(100, 500));
            }


            _out = new GETiout() { patient = pOSTin.patient, services = pOSTin.services };

            foreach (var item in _out.services)
            {
                item.result = "good";
            }


            return StatusCode(StatusCodes.Status200OK, "ok" );
          
        }

        [HttpGet]
        public ObjectResult InPost()
        {

            if (_out != null)
              return StatusCode(StatusCodes.Status200OK, _out);

            return StatusCode(StatusCodes.Status400BadRequest, "Анализатор занят");

        }
    }
    }

    

