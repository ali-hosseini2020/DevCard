using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>()
            {
                new Project(1,"تاکسی","درخواست آنلاین تاکسی برای سفرهای درون شهری","project-1.jpg","Atria"),
                new Project(2,"زود فود","درخواست آنلاین غذا برای سراسر کشور","project-2.jpg", "ZOODFood"),
                new Project(3,"مدارس","سیستم مدیریت یکپارچه مدارس","project-3.jpg", "MONOP"),
                new Project(4,"فضاپیما","برنامه مدیریت فضاپیما های ناسا","project-4.jpg", "NASA"),

            };

            return View("_Projects",projects);
        }
    }
}
