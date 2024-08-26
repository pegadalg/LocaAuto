using Locacoes.Models;
using Microsoft.AspNetCore.Mvc;


namespace Locacoes.Controllers
{
    public class ClientController : Controller
    {
        //public static List<Client> Clients = new List<Client>()
        //{
        //    new Client()
        //    {
        //        Id = 1,
        //        Nome = "Rebeca",
        //        Email = "rebecaAndrade@mail.com",
        //        Telefone = "(21)999887799",
        //        Cidade = "Rio de janeiro"
        //    },
        //    new Client()
        //    {
        //        Id = 2,
        //        Nome = "Medina",
        //        Email = "gabrielMedina@mail.com",
        //        Telefone = "(13)998887744",
        //        Cidade = "Santos"
        //    },
        //};


        public IActionResult Index()
        {
            return View(Clients);
        }

        public IActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(Client client)
        //{
            
        //    client.Id = Clients.Select(x => x.Id).Max() + 1;
        //    Clients.Add(client);
        //    return RedirectToAction("Index");
        //}


        //public IActionResult Edit(int id)
        //{
            
        //    return View(Clients.Where(x => x.Id == id).First());
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(Client client)
        //{
        //    var clientOld = Clients.Where(x => x.Id == client.Id).First();
        //    Clients.Remove(clientOld);
        //    Clients.Add(client);
        //    return RedirectToAction("Index");

            
        //}

        //public IActionResult Details(int id)
        //{
        //    return View(
        //        Clients.Where(x => x.Id == id).Select(x => new Client()
        //        {
        //            Nome = x.Nome,
        //            Email = x.Email,
        //            Telefone = x.Telefone,
        //            Cidade = x.Cidade
        //        }).First()
        //        );
        //}

        //public IActionResult Delete(int id)
        //{
        //    return View(
        //        Clients.Where(x => x.Id == id).First()
                
        //     );
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Delete(Client client)
        //{
        //    var clientRemove = Clients.Where(x => x.Id == client.Id).First();
        //    Clients.Remove(clientRemove);
        //    return RedirectToAction("Index");
        //}


    }
}
