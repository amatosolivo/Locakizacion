using Localizaciones.WebSite.Modelos;
using Localizaciones.WebSite.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localizaciones.WebSite.Controladores
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        public PersonasController(ArchivoJsonPersonasServicio personaServicio)
        {
            this.PersonaServicio = personaServicio;
        }

        public ArchivoJsonPersonasServicio PersonaServicio { get;  }

        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            return PersonaServicio.GetPersonas();
        }
    }
}
