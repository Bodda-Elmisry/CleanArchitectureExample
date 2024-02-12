using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ICustomServices
{
    public interface IGetCustomService <T>
    {
        IEnumerable<T> GetAll();
        T FiendByID(int id);
    }
}
