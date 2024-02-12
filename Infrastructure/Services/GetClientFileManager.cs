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
    public class GetClientFileManager : IGetClientFileManager, IClientFileManagerBase
    {
        private readonly IGetClientFileRepository _clientFileRepository;
        public GetClientFileManager(IGetClientFileRepository clientFileRepository)
        {
            _clientFileRepository = clientFileRepository;
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
