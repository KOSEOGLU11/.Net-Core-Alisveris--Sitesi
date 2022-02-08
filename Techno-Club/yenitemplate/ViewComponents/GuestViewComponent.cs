using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yenitemplate.Models;

namespace yenitemplate.ViewComponents
{
    public class GuestViewComponent: ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            var GuestList = new List<GuestResponse>
            {
                new GuestResponse
                {
                    name="Misafir1 ismi", email="misafir1 email", Message="mesaj"


                },

                new GuestResponse
                {
                    name="misafir2 ismi", email="misafir2 mail", Message="mesaj"
                }
            };
            return View(GuestList);

        }
    }
}

