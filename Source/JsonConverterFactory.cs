
namespace Ada.Framework.Data.Json
{
    /// <summary>
    /// Factoría del convertidor Json.
    /// </summary>
    /// <remarks>
    ///     Registro de versiones:
    ///     
    ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
    /// </remarks>
    public class JsonConverterFactory
    {
        /// <summary>
        /// Obtiene la implementación del convertidor a Json.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        /// <returns>IJsonConverter.</returns>
        public static IJsonConverter ObtenerJsonConverter()
        {
            return new JsonConverter();
        }
    }
}
