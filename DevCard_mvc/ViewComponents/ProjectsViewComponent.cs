using System.Collections.Generic;
using DevCard_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_mvc.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>()
            {
                new Project(id: 1, name: "ﺍﻳﺠﺎﺩ محیطی ﻣﻨﺎﺳﺐ ﺟﻬﺖ ارزیابی های ﻣﺴﺘﻤﺮ ﻭ ﻣﺘﻨﺎﺳﺐ ﺑﺎ ﺍﺳﺘﻌﺪﺍﺩ ﻭ ﭘﻴﺸﺮﻓﺖ",
                    image: "classroom.jpg", title: "فرزند هایتان",
                    description:
                    "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز، و کاربردهای متنوع",
                    client: "بیشتر بدانید"),
                new Project(id: 2, name: "ﺍﻳﺠﺎﺩ محیطی ﻣﻨﺎﺳﺐ ﺟﻬﺖ ارزیابی های ﻣﺴﺘﻤﺮ ﻭ ﻣﺘﻨﺎﺳﺐ ﺑﺎ ﺍﺳﺘﻌﺪﺍﺩ ﻭ ﭘﻴﺸﺮﻓﺖ",
                    image: "Collaboration.jpeg", title: "فرزند هایتان",
                    description:
                    "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز، و کاربردهای متنوع",
                    client: "بیشتر بدانید"),

            };
            return View("_Projects", projects);
        }
    }
}