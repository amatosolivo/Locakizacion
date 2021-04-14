using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Localizaciones.WebSite.Modelos
{
    public class Persona
    {
        [JsonPropertyName("personaId")]
        public string PersonaId { get; set; }
        
        //[JsonPropertyName("tipo")]
        //[JsonConverter(typeof(StringEnumConverter))]
        //public TipoPersona TipoPersona { get; set; }

        [JsonPropertyName("fotoUrl")]
        public string Foto { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombres { get; set; }

        [JsonPropertyName("primerApellido")]
        public string PrimerApellido { get; set; }

        [JsonPropertyName("segundoApellido")]
        public string SegundoApellido { get; set; }

        [JsonPropertyName("sexo")]
        public string Sexo { get; set; }

        [JsonPropertyName("activo")]
        public bool Activo { get; set; }

        [JsonPropertyName("direcciones")]
        public List<Direccion> Direcciones { get; set; }

        public override string ToString() => JsonSerializer.Serialize <Persona> (this);
        
    }
}
