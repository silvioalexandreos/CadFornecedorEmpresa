using CadEmpresaFornecedor.Services.Modules.Empresas;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CadEmpresaFornecedor.Api.Controllers
{
    
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class EmpresasController : ControllerBase
    {
        private readonly EmpresaService _empresaService;
        public EmpresasController(EmpresaService empresaService)
        {
            _empresaService = empresaService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var empresas = await _empresaService.ObterTodasEmpresas();
            return Ok(empresas);
        }
    }
}
