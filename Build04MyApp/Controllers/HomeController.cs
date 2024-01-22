using Build04MyApp.Data;
using Build04MyApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using System.Diagnostics;

namespace Build04MyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public AllStories _stories;
       
        public HomeController(ILogger<HomeController> logger, AllStories stories)
        {
            _logger = logger;
            _stories = stories;
        }

        public IActionResult Index()
        {
            List<Story> stories_all = _stories.getAllStories();

            return View(stories_all);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult StoryDescription(int? id)
        {

            Story stroyDes = new Story();
            List<Story> stories_all = _stories.getAllStories();
            foreach (Story story in stories_all)
            {
                if (story.Id == id)
                {
                    stroyDes = story;
                }
                else
                {
                    RedirectToAction("Index");
                }
            }
            return View(stroyDes);
        }

        public  IActionResult ClientStoryAction()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ClientStoryAction(ClientStory clientStory)
        {
            
            ViewData["flag"] = "failed";
            ModelState.Remove("Phone");
            if (ModelState.IsValid)
            {
                ClientStory clientStorydb = new ClientStory();
                clientStorydb.id = clientStory.id;
                clientStorydb.Name = clientStory.Name;
                clientStorydb.Title = clientStory.Title;
                clientStorydb.Email = clientStory.Email;
                clientStorydb.StoryDes = clientStory.StoryDes;
                clientStorydb.Phone = clientStory.Phone;
                var url = "https://thisismystorycosmosdb.documents.azure.com:443/";
                var db = "ClientStoryDB";
                var key = "q4VGXuIjwV4qXmaH7qIERGyprjcWDNriAC8r7c5m9HB90w9vyAVMnEnkXrkg5vzp6GAnglordtnEACDbtJnPOg==";
                CosmosClient client = new CosmosClient(url, key);
                Database database = await client.CreateDatabaseIfNotExistsAsync(db);
                Container container = await database.CreateContainerIfNotExistsAsync("ClientStory", "/id");
                var response = await container.CreateItemAsync<ClientStory>(clientStorydb);
                ViewData["flag"] = "success";
                return View();
            }
            else { return View(); }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}