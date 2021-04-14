using System.Runtime.Serialization;

namespace Localizaciones.WebSite.Modelos
{
    public enum TipoPersona
    {
        [EnumMember(Value = "Persona Fisica")]
        FISICA,

        [EnumMember(Value = "Negocio")]
        COMERCIAL,
    }
}
