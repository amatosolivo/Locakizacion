using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Localizaciones.WebSite.Modelos;
using Microsoft.AspNetCore.Hosting;

namespace Localizaciones.WebSite.Servicios
{
    public class ArchivoJsonPersonasServicio
    {
        public ArchivoJsonPersonasServicio(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string NombreArchivoJson
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "personas.json"); }
        }

        public IEnumerable<Persona> GetPersonas()
        {
            using (var lectorArchivoJson = File.OpenText(NombreArchivoJson))
            {
                return JsonSerializer.Deserialize <Persona[]>(lectorArchivoJson.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = false
                    });
            }
        }

        public void InactivarPersona(string personaId)
        {
            var personas = GetPersonas();

            var query = personas.First(x => x.PersonaId == personaId);
            query.Activo = false;
        }
    }
}
