using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Blog.Models;

namespace Razor_Blog.Pages
{
    public class CreateArticleModel : PageModel
    {
        private readonly BlogContext _blogContext;
        [TempData]
        public string ErrorMessage { get; set; }
       // [TempData]
       // public string SuccessMessage { get; set; }
        public CreateArticle Command { get; set; }

        public CreateArticleModel(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public void OnGet()
        {
        }



        public IActionResult OnPost(CreateArticle command)
        {
            if (ModelState.IsValid)
            {
                var article = new Article(command.Title, command.Picture, command.PictureAlt, command.PictureTitle,
                    command.ShortDescription, command.Body);
                _blogContext.Articles.Add(article);
                _blogContext.SaveChanges();
               // SuccessMessage = "مقاله با مو فقیت  ذخیره شد";
               return RedirectToPage("./Index");
            }
            else
            {
                ErrorMessage = "لطفا مقادیر خواسته شده را تکمیل نمایید";
                return Page();
            }
            


        }
    }
}