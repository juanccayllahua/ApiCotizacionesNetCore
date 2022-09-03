﻿using Lucky.EyGH.BussinessLogic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky.EyGH.WebAPI.controller
{
    [Route("apiLucky/v0.1/ciudades")]
    [Produces("application/json")]

    public class CiudadesApiController: Controller
    {

        [HttpGet]
        public JsonResult Get( )
        {//[FromBody] string param
            CotizacionB cotizacionB = new CotizacionB();
            //cotizacionB.listarArticulos();

            return Json(cotizacionB.listarCiudades());
        }


    }
}
