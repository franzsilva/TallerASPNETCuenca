using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TallerASPNET.Models;

namespace TallerASPNET.Pages.Participantes
{
    public class EditModel : PageModel
    {
        private readonly TallerASPNET.Models.TallerContext _context;

        public EditModel(TallerASPNET.Models.TallerContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Participante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParticipanteExists(Participante.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ParticipanteExists(int id)
        {
            return _context.Participante.Any(e => e.ID == id);
        }
    }
}
