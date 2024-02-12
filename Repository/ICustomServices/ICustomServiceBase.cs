using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ICustomServices
{
    public interface ICustomServiceBase <T>
    {
       int GetCount(Expression<Func<T, bool>> expression);
    }
}
