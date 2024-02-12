using Doamin.Entities;
using Repository.IRepositories;
using Repository.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class PostClientFileManager : IPostClientFileManager, IClientFileManagerBase
    {
        private readonly IPostClientFileRepository _clientFileRepository;
        public PostClientFileManager(IPostClientFileRepository clientFileRepository)
        {
            _clientFileRepository = clientFileRepository;
        }
        public bool CreateFile(ClientFile file)
        {
            if (!IsFileExist(file.Id))
            {
                _clientFileRepository.Inert(file);
            }
            return true;
        }

        public bool IsFileExist(int id)
        {
            var count = _clientFileRepository.GetCount(c=> c.Id == id);
            return count > 0;

        }
    }
}
