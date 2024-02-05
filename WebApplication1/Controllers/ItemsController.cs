using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/Items")] // api/Librarian
    [ApiController]
    public class ItemsController : Controller
    {
        [HttpGet("")]
        //[NonAction]
        public IEnumerable<string> Index()
        {
            var ss = new List<string>();
            ss.Add("1");
            ss.Add("2");
            return ss;
        }

        [HttpGet("GetItems")]
        public List<Item> GetItems()
        {
            var items = new List<Item>();

            Item item= new Item()
            {
                Id = 1,
                Code = "sms1",
                Name = "Samsung 15",
                Description = "Ram 20",
                Price = 550,
                Weight = 15
            };

            item.SetDimentions("51,30,20");
            item.Description += ", Dimantions = " 
                + item.GetDimentions();

            items.Add(item);

            return items;
        }



    }
}
