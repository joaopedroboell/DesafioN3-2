using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServidorWeb.Controllers.Base;
using ServidorWeb.Infra.dtos;
using ServidorWeb.Services;

namespace ServidorWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacaoController : BaseApiController
    {
        private readonly IOperacaoServices _operacaoServices;
        public OperacaoController(IOperacaoServices operacaoServices)
        {
            _operacaoServices = operacaoServices;
        }
        
        
        [HttpGet()]
        public ActionResult Get() => Ok();

        [HttpGet("{valor}")]
        public async Task<ActionResult> GetResultAsync(double valor) => Ok(await _operacaoServices.GetResultAsync(valor));

    }
}
