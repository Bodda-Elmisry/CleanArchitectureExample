using Doamin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IServices
{
    public interface IClientFileManager
    {
        ClientFile GetFile(int id);

        IEnumerable<ClientFile> GetFiles();

        bool IsFileExist(int id);

        bool CreateFile(ClientFile file);

    }
}
