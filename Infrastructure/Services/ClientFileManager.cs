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
    public class ClientFileManager : IClientFileManager
    {
        private readonly IClientFileRepository _clientFileRepository;
        public ClientFileManager(IClientFileRepository clientFileRepository)
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

        public ClientFile GetFile(int id)
        {
            return _clientFileRepository.FiendByID(id);
        }

        public IEnumerable<ClientFile> GetFiles()
        {
            return _clientFileRepository.GetAll();
        }

        public bool IsFileExist(int id)
        {
            var count = _clientFileRepository.GetCount(c=> c.Id == id);
            return count > 0;

        }
    }
}
