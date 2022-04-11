using Microsoft.AspNetCore.Mvc;
using CadastroTeste.Services;
using CadastroTeste.Models;

namespace CadastroTeste.Controllers
{
    public class CadastroController : BaseController<Cadastro>
    {
        public CadastroController(ICadastroService serv) : base(serv)
        {
            
        }     
    }
}