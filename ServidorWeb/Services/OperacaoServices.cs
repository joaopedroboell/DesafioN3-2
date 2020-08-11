using ServidorWeb.Infra.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServidorWeb.Services
{
    public class OperacaoServices : IOperacaoServices
    {
        public async Task<OperacaoDto> GetResultAsync(double valor)
        {
            var result = new OperacaoDto();
            await Task.Run(() =>
            {
                result.Resultado = Math.Sqrt(valor);
            });
            return result;
        }
    }
}
