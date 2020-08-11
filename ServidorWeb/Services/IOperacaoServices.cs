using ServidorWeb.Infra.dtos;
using System.Threading.Tasks;

namespace ServidorWeb.Services
{
    public interface IOperacaoServices
    {
        Task<OperacaoDto> GetResultAsync(double valor);
    }
}