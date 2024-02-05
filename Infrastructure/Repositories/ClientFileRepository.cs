﻿using Doamin.Entities;
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
    public class ClientFileRepository : IClientFileRepository
    {
        private readonly AppDbContext context;

        public ClientFileRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Delete(ClientFile entity)
        {
            context.ClientsFiles.Remove(entity);
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

        public void Inert(ClientFile entity)
        {
            context.ClientsFiles.Add(entity);
            context.SaveChanges();
        }

        public async Task<ClientFile> Update(ClientFile entity)
        {
            context.ClientsFiles.Update(entity);
            await Task.Run(() => context.SaveChanges());
            return entity;
        }
    }
}
