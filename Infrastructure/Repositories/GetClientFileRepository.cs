using Doamin.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore.Storage;
using Repository.ICustomServices;
using Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class GetClientFileRepository : IGetClientFileRepository
    {
        private readonly AppDbContext context;

        public GetClientFileRepository(AppDbContext context)
        {
            this.context = context;
        }

        public ClientFile FiendByID(int id)
        {
            return context.ClientsFiles.FirstOrDefault(c => c.Id == id);
        }

        public int GetCount(Expression<Func<ClientFile, bool>> expression)
        {
            return context.ClientsFiles.Where(expression).Count();
        }

        public IEnumerable<ClientFile> GetAll()
        {
            return context.ClientsFiles.ToList();
        }
    }
}
