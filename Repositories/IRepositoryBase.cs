using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace CadastroTeste.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<List<T>> Get();
        Task<T> GetById(int Id);
        Task Add(T entity); 
        Task Remove(T entity);
        Task Update(T entity);
    }
}