using Doamin.Entities;
using Microsoft.AspNetCore.Mvc;
using Repository.IServices;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/FileManager")] // api/Librarian
    [ApiController]
    public class FileManagerController : Controller
    {
        private readonly IClientFileManager _clientFileManager;
        public FileManagerController(IClientFileManager clientFileManager)
        {
            _clientFileManager = clientFileManager;
        }


        //[HttpGet("")]
        ////[NonAction]
        //public IEnumerable<string> Index()
        //{
        //    var ss = new List<string>();
        //    ss.Add("1");
        //    ss.Add("2");
        //    return ss;
        //}

        [HttpGet("GetFiles")]
        public IActionResult GetFiles()
        {
            var filesList = _clientFileManager.GetFiles();
            return Ok(filesList);
        }

        [HttpGet("GetFileByID")]
        public IActionResult GetFileById(int id)
        {
            var file = _clientFileManager.GetFile(id);
            return Ok(file);
        }

        [HttpPost("AddFile")]
        public IActionResult AddFile(ClientFile file)
        {
            try
            {
                _clientFileManager.CreateFile(file);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }





    }
}
