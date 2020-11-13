using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using Newtonsoft.Json;
using BookWeb.Helper;
using BookWeb.Models;

namespace BookWeb.Controllers
{
    public class BooksController : Controller
    {
        BookAPI _api = new BookAPI();

        public async Task<IActionResult> Index()
        {
            List<Book> book = new List<Book>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/books");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                book = JsonConvert.DeserializeObject<List<Book>>(results);
            }
            return View(book);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
		{
			var book = new Book();
			HttpClient client = _api.Initial();
			HttpResponseMessage res = await client.GetAsync($"api/books/{id}");
			if (res.IsSuccessStatusCode)
			{
				var result = res.Content.ReadAsStringAsync().Result;
				book = JsonConvert.DeserializeObject<Book>(result);
			}
			return View(book);

		}

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            HttpClient client = _api.Initial();
            var postTask = client.PostAsJsonAsync<Book>("api/books", book);

            var result = postTask.Result;
            if(result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();

        }

        public async Task<IActionResult> Delete(int id)
        {
            var book = new Book();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.DeleteAsync($"api/books/{id}");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
		{
			var book = new Book();
			HttpClient client = _api.Initial();
			HttpResponseMessage res = await client.GetAsync($"api/books/{id}");
			if (res.IsSuccessStatusCode)
			{
				var result = res.Content.ReadAsStringAsync().Result;
				book = JsonConvert.DeserializeObject<Book>(result);
			}
			return View(book);

		}

        
        [HttpPost]
        public async Task<IActionResult> Edit(Book book)
        {
            HttpClient client = _api.Initial();

            HttpResponseMessage response = await client.PutAsJsonAsync($"api/books/{book.Id}", book);
            response.EnsureSuccessStatusCode();

            book = await response.Content.ReadAsAsync<Book>();
            
            return RedirectToAction("Index");

        }
    }
}
