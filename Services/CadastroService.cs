using CadastroTeste.Models;
using CadastroTeste.Repositories;

namespace CadastroTeste.Services
{
    public class CadastroService : ServiceBase<Cadastro>, ICadastroService
    {
        
        public CadastroService(ICadastroRepository rep) : base(rep)
        {
           
        } 
    }
}