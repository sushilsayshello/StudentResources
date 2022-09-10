using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentResources.Models;

namespace StudentResources.Controllers
{
    public class ResourceController : Controller
    {
        List<ResourceModel> resource = new List<ResourceModel>()
        {
               new ResourceModel { ResourceId = 1, ResourceName = "Laptop", ResourceType = "Level 1 Valuable", ResourceAvailability = true, ResourceQuantity = 100 },
               new ResourceModel { ResourceId = 2, ResourceName = "Android", ResourceType = "Level 2 Valuable", ResourceAvailability = false, ResourceQuantity = 50},
               new ResourceModel { ResourceId = 3, ResourceName = "Iphone", ResourceType = "Level 1 Valuable", ResourceAvailability = true, ResourceQuantity = 200},
               new ResourceModel { ResourceId = 4, ResourceName = "Tablet", ResourceType = "Level 2 Valuable", ResourceAvailability = false, ResourceQuantity = 40}
        };

        // GET: Person
        public ActionResult Index()
        {
            return View(resource);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ResourceModel per)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Create", per);
                }
                resource.Add(per);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            ResourceModel per = resource.Find(res => res.ResourceId == id);
            return View(per);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ResourceModel per = resource.Find(res => res.ResourceId == id);
            return View(per);
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}
