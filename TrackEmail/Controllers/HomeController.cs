using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrackEmail.Models;
using System.Xml;
using Microsoft.Extensions.Hosting;
using System.IO;
using Newtonsoft.Json;

namespace TrackEmail.Controllers
{
    public class HomeController : Controller
    {
        public class User
        {
            public string Name { get; set; }
            public string EmailOpened { get; set; }
        }

        private readonly IHostingEnvironment _host;

        public HomeController(IHostingEnvironment host)
        {
            _host = host;
        }
        public IActionResult Index()
        {
            List<User> users = new List<User>();
            var dir = String.Format("{0}\\wwwroot\\Data", _host.ContentRootPath);
            var xmlPath = Path.Combine(dir, "Data.xml");
            var xmlFile = new FileInfo(xmlPath);

            if (xmlFile.Exists)
            {
                //Read the xml
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlPath);
                XmlNodeList nodes = doc.SelectNodes("Data/User");
                foreach (XmlNode node in nodes)
                {
                    XmlElement element = (XmlElement)node;
                    XmlNodeList childNodes = node.ChildNodes;
                    User user = new User() { Name = childNodes[0].InnerText, EmailOpened = childNodes[2].InnerText };
                    users.Add(user);
                }
            }

            string userJsonString = JsonConvert.SerializeObject(users);
            ViewData["Users"] = userJsonString;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
