using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using DevCard_MVC.Models;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1, "آموزش Asp.net core mvc", "کامل ترین پکیج آموزش asp .net core mvc به  زبان فارسی",
                    "blog-post-thumb-card-1.jpg"),
                new Article(2, "آموزش Git & Github", "کامل ترین پکیج آموزش Git & Github به  زبان فارسی",
                    "blog-post-thumb-card-2.jpg"),
                new Article(3, "آموزش Onion Architecture", "کامل ترین پکیج آموزش  Onion Architecture به  زبان فارسی",
                    "blog-post-thumb-card-3.jpg"),
                new Article(4, "آموزش طراحی سایت", "کامل ترین پکیج آموزشآموزش طراحی سایت به  زبان فارسی",
                    "blog-post-thumb-card-4.jpg"),
            };

            return View("_LatestArticles",articles);
        }
    }
}