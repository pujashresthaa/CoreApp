using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using IEnsure.Models;


namespace IEnsure.Pages
{
    public class CountryModel : PageModel
    {
        DatabaseContext _Context;
        public CountryModel(DatabaseContext databasecontext)

        {
            _Context = databasecontext;
        }

        [BindProperty]
        public Country Country { get; set; }

        public void OnGet()
        {
            
        }
        public ActionResult OnPost()
        {
            var country = Country;
            if(!ModelState.IsValid)
            {
                return Page();

            }
            country.CountryId = 0;
            var result = _Context.Add(country);
            _Context.SaveChanges();
            return RedirectToPage("AllCountry");
        }
    }
}
