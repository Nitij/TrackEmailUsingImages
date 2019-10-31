using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.Extensions.Hosting;
using System.Xml;

namespace TrackEmail.Controllers
{
    public class ImageController : Controller
    {
        private readonly IHostingEnvironment _host;

        public ImageController(IHostingEnvironment host)
        {
            _host = host;
        }

        public IActionResult GetImg(string id)
        {
            var dir = string.Format("{0}\\wwwroot\\data", _host.ContentRootPath);

            bool saveXml = false;
            var xmlPath = Path.Combine(dir, "data.xml");
            var xmlFile = new FileInfo(xmlPath);

            if(xmlFile.Exists)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlPath);
                XmlNodeList nodes = doc.SelectNodes("Data/User");
                foreach(XmlNode node in nodes)
                {
                    XmlElement el = (XmlElement)node;
                    XmlNodeList childNodes = node.ChildNodes;
                    if(childNodes[1].InnerText == id)
                    {
                        childNodes[2].InnerText = "Yes";
                        saveXml = true;
                        break;
                    }
                }

                if(saveXml)
                {
                    doc.Save(xmlPath);
                }
            }

            dir = string.Format("{0}\\wwwroot\\images", _host.ContentRootPath);
            var imagePath = Path.Combine(dir, "image.jpg");
            var imageFile = new FileInfo(imagePath);
            if(imageFile.Exists)
            {
                return File(System.IO.File.ReadAllBytes(imagePath), "image/jpg");
            }

            return View();
        }
    }
}