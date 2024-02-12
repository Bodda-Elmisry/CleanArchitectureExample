﻿using Doamin.Entities;
using Repository.ICustomServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepositories
{
    public interface IGetClientFileRepository : IGetCustomService<ClientFile>, ICustomServiceBase<ClientFile>
    {
    }
}
