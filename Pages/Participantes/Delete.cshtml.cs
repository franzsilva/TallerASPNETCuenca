using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TallerASPNET.Models;

namespace TallerASPNET.Pages.Participantes
{
    public class DeleteModel : PageModel
    {
        private readonly TallerASPNET.Models.TallerContext _context;

        public DeleteModel(TallerASPNET.Models.TallerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Participante Participante { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Participante = await _context.Participante.FirstOrDefaultAsync(m => m.ID == id);

            if (Participante == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Participante = await _context.Participante.FindAsync(id);

            if (Participante != null)
            {
                _context.Participante.Remove(Participante);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
