using Microsoft.AspNetCore.Mvc;
using Mission11_Fietkau.Models;
using Mission11_Fietkau.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_Fietkau.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookRepository _repo;

        public HomeController(ILogger<HomeController> logger, IBookRepository temp)
        {
            _logger = logger;
            _repo = temp;
        }

        public IActionResult Index(int PageNum)
        {

            int PageSize = 10;
            var blah = new BooksListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((PageNum - 1) * PageSize)
                .Take(PageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = PageNum,
                    ItemsPerPage = PageSize,
                    TotalItems = _repo.Books.Count()
                }

            }; 


            return View(blah);
        }

       



    }
}
