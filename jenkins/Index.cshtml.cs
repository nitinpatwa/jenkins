using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using IRUtility;

namespace jenkins
{
    public class IndexModel : PageModel
    {
        public string OnGet()
        {
            string date;
            IRUtility.Message p = new Message();
          return  date = p.Date();
            Console.WriteLine(date);
        }
    }
}
