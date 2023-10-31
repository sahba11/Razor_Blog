using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Razor_Blog.Models;


namespace Razor_Blog.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;
        public List<ArticleViewModel> Articles { get; set; }
        private readonly BlogContext _context;

        public IndexModel(BlogContext context)
        {
            _context = context;

        }

        public void OnGet()
        {
            Articles = _context.Articles.Select(x=> new ArticleViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription,
                
            }).OrderByDescending(x=>x.Id).ToList();

        }

        public void OnPost(IFormCollection form)
        { }

        public IActionResult Load()
        {
            return Page();
        }
        public ActionResult OnGetLoad()
        {

            return RedirectToPage("/.Index");
            // return Page();
        }
    }
}
