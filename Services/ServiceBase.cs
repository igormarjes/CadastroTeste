using CadastroTeste.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroTeste.Repositories;

namespace CadastroTeste.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
       private readonly IRepositoryBase<T> rep;

        public ServiceBase(IRepositoryBase<T> rep)
        {
            this.rep = rep;
        }

        public async Task<List<T>> Get()
        {
            return await rep.Get();
        }

        public async Task<T> GetById(int Id)
        {
            return await rep.GetById(Id);
        }

        public async Task Add(T entity)
        {
            await rep.Add(entity);
        }

        public async Task Update(T entity)
        {
            await rep.Update(entity);
        }

        public async Task Remove(T entity)
        {
            await rep.Remove(entity);
        }
 
    }
}