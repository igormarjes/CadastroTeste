using CadastroTeste.Models;
using CadastroTeste.DAO;

namespace CadastroTeste.Repositories
{
    public class CadastroRepository : RepositoryBase<Cadastro, CadastroContext>, ICadastroRepository
    {
        public CadastroRepository(CadastroContext context) : base(context) {}
    }
}