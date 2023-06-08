using BaseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaseApp.Controllers
{
    public class ContactsController : Controller
    {
        private static List<Contact> contacts = new List<Contact>();

        public IActionResult Index()
        {
            return View(contacts);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            contacts.Add(contact);
            return RedirectToAction("Index");
        }
    }
}
