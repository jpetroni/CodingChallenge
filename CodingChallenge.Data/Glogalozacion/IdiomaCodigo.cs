using System;
using System.ComponentModel;
using System.Reflection;

namespace CodingChallenge.Data.Glogalozacion
{
    public enum IdiomaCodigo
    { 
        [Description("es-AR")]
        ES_AR = 1,
        [Description("en-US")]
        EN_US = 2, 
        [Description("fr-FR")]
        FR_FR = 3
    }
    internal static class Extensions
    {
        public static string ObtenerDescripcion(this Enum valor)
        {
            FieldInfo field = valor.GetType().GetField(valor.ToString());
            DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute == null ? valor.ToString() : attribute.Description;
        }
    }
}
