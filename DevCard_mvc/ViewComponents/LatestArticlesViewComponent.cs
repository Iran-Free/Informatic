using System.Collections.Generic;
using DevCard_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_mvc.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>()
            {
                new Article(id: 1, image: "job.jpg", title: "آمادگی شغلی",
                    description: "تقویت مهارت ها برای آینده ایی درخشان"),
                new Article(id: 2, image: "support.jpg", title: "آمادگی شغلی",
                    description: "تقویت مهارت ها برای آینده ایی درخشان"),
                new Article(id: 3, image: "Technology.jpg", title: "آمادگی شغلی",
                    description: "تقویت مهارت ها برای آینده ایی درخشان"),
                new Article(id: 4, image: "Collaboration.jpg", title: "آمادگی شغلی",
                    description: "تقویت مهارت ها برای آینده ایی درخشان")
            };
            return View("_LatestArticles", articles);
        }
    }
}