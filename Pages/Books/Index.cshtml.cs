using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Biscos_Georgiana_Vanessa_Lab8.Data;
using Biscos_Georgiana_Vanessa_Lab8.Models;

namespace Biscos_Georgiana_Vanessa_Lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Biscos_Georgiana_Vanessa_Lab8Context _context;

        public IndexModel(Biscos_Georgiana_Vanessa_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context
                .Book
                .Include(p => p.Publisher)
                .ToListAsync();
        }
    }
}
