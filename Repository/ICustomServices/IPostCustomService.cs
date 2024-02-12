using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ICustomServices
{
    public interface IPostCustomService <T>
    {
        void Inert(T entity);
        Task<T> Update(T entity);
        void Delete(T entity);
    }
}
