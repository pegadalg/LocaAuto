using Locacoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Locacoes.Controllers
{
    public class ProducerController : Controller
    {

        public static List<Producer> Producers = new List<Producer>()
        {
            new Producer()
            {
                Id = 1,
                Nome = "Nissan",
                Pais = "Japão"
            },
            new Producer()
            {
                Id = 2,
                Nome = "Honda",
                Pais = "Japão"
            },
        };



        public IActionResult Index()
        {
            return View(Producers);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Producer producer)
        {
            if (Producers.Contains(producer))
            {
                producer.Id = Producers.Select(x => x.Id).Max() + 1;
            }
            else
            {
                producer.Id = 1;
            }
            
            Producers.Add(producer);
            return RedirectToAction("Index"); 
        }

        public IActionResult Edit(int id)
        {

            return View(Producers.Where(x => x.Id == id).First());

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Producer producer)
        {
            var producerOld = Producers.Where(x => x.Id == producer.Id).First();
            Producers.Remove(producerOld);
            Producers.Add(producer);
            return RedirectToAction("Index");


        }

        public IActionResult Details(int id)
        {
            return View(
                Producers.Where(x => x.Id == id).Select(x => new Producer()
                {
                    Nome = x.Nome,
                    Pais = x.Pais,
                }).First()
                );
        }

        public IActionResult Delete(int id)
        {
            return View(
                Producers.Where(x => x.Id == id).First()

             );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Producer producer)
        {
            var producerRemove = Producers.Where(x => x.Id == producer.Id).First();
            Producers.Remove(producerRemove);
            return RedirectToAction("Index");
        }









    }

}

//
