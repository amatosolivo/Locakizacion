using Localizaciones.WebSite.Modelos;
using Localizaciones.WebSite.Servicios;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Localizaciones.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public ArchivoJsonPersonasServicio PersonaServicio;
        public IEnumerable<Persona> Personas { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger, 
            ArchivoJsonPersonasServicio personaServicio)
        {
            _logger = logger;
            PersonaServicio = personaServicio;
        }

        public void OnGet()
        {
            Personas = PersonaServicio.GetPersonas();
        }
    }
}
