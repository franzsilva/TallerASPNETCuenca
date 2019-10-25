using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TallerASPNET.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        [ViewData]
        public string Mensaje { get; set; }

        [ViewData]
        public List<string> MiLista { get; set; }


        public void OnGet()
        {
            MiLista = new List<string>();

            MiLista.Add("Primer Dia");
            MiLista.Add("Segunda Dia");
            MiLista.Add("Tercer Dia");


            Mensaje = "Bienvenidos a la pagina de Privacy";
        }
    }
}
