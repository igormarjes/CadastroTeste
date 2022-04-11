using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroTeste.Services
{
    public interface IServiceBase<T>
    {
        Task<List<T>> Get();
        Task<T> GetById(int Id);
        Task Add(T entity);
        Task Remove(T entity);
        Task Update(T entity);  
    }
}