using Localizaciones.WebSite.Modelos;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Localizaciones.WebSite.Modelos
{
    public class Direccion : ObjetoValor
    {
        [JsonPropertyName("descripcion")]
        public String Descripcion { get; set; }

        [JsonPropertyName("latitud")]
        public String Latitud { get; set; }

        [JsonPropertyName("longitud")]
        public String Longitud { get; set; }

        [JsonPropertyName("ciudad")]
        public String Ciudad { get; set; }

        [JsonPropertyName("sector")]
        public String Sector { get; set; }

        [JsonPropertyName("subSector")]
        public String SubSector { get; set; }

        [JsonPropertyName("codigoPostal")]
        public String CodigoPostal { get; set; }

        [JsonPropertyName("calle")]
        public String Calle { get; set; }

        [JsonPropertyName("municipio")]
        public String Municipio { get; set; }

        [JsonPropertyName("provincia")]
        public String Provincia { get; set; }

        [JsonPropertyName("pais")]
        public String Pais { get; set; }

        [JsonPropertyName("dato")]
        public String Dato { get; set; }

        [JsonPropertyName("actual")]
        public Boolean Actual { get; set; }

        public Direccion() { }


        public Direccion(string descripcion, string latitud, string longitud, string ciudad, string sector, string subSector, string codigoPostal, string calle, string municipio, string provincia, string pais, string dato, bool actual)
        {
            Descripcion = descripcion;
            Latitud = latitud;
            Longitud = longitud;
            Ciudad = ciudad;
            Sector = sector;
            SubSector = subSector;
            CodigoPostal = codigoPostal;
            Calle = calle;
            Municipio = municipio;
            Provincia = provincia;
            Pais = pais;
            Dato = dato;
            Actual = actual;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Calle;
            yield return Sector;
            yield return SubSector;
            yield return Ciudad;
            yield return Provincia;
            yield return Pais;
            yield return CodigoPostal;
            yield return Longitud;
            yield return Latitud;
        }

        public override string ToString() => JsonSerializer.Serialize<Direccion>(this);
    }
}
