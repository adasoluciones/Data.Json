
namespace Ada.Framework.Data.Json
{
    /// <summary>
    /// Interface IJsonConverter
    /// </summary>
    /// <remarks>
    ///     Registro de versiones:
    ///     
    ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
    /// </remarks>
    public interface IJsonConverter
    {
        /// <summary>
        /// Método que permite transformar objetos serializables en Json.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        /// <exception cref="Ada.Framework.Data.Json.Exceptions.JsonConvertException"></exception>
        /// <param name="objeto">Objeto a transformar.</param>
        /// <returns>Json.</returns>
        string ToJson(object objeto);

        /// <summary>
        /// Método que permite transformar objetos serializables en Json.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        /// <exception cref="Ada.Framework.Data.Json.Exceptions.JsonConvertException"></exception>
        /// <param name="objeto">Objeto a transformar.</param>
        /// <param name="incluirTipo">Incluir información sobre el tipo del objeto.</param>
        /// <returns>Json.</returns>
        string ToJson(object objeto, bool incluirTipo);

        /// <summary>
        /// Método que permite deserializar un json en el objeto original.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        /// <exception cref="Ada.Framework.Data.Json.Exceptions.JsonConvertException"></exception>
        /// <param name="json">Json que representa el objeto original.</param>
        /// <returns>El objeto original contenido en el Json.</returns>
        object ToObject(string json);

        /// <summary>
        /// Método que permite deserializar un json en el objeto original.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        /// <param name="json">Json que representa el objeto original.</param>
        /// <param name="incluirTipo">Incluir información sobre el tipo del objeto.</param>
        /// <returns>El objeto original contenido en el Json.</returns>
        /// <exception cref="Ada.Framework.Data.Json.Exceptions.JsonConvertException"></exception>
        object ToObject(string json, bool incluirTipo);

        /// <summary>
        /// Método que permite deserializar un json en el objeto original.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        /// <typeparam name="T">Tipo del objeto original.</typeparam>
        /// <exception cref="Ada.Framework.Data.Json.Exceptions.JsonConvertException"></exception>
        /// <param name="json">Json que representa el objeto original.</param>
        /// <returns>El objeto original contenido en el Json.</returns>
        T ToObject<T>(string json);

        /// <summary>
        /// Método que permite deserializar un json en el objeto original.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        /// <typeparam name="T">Tipo del objeto original.</typeparam>
        /// <param name="json">Json que representa el objeto original.</param>
        /// <param name="incluirTipo">Incluir información sobre el tipo del objeto.</param>
        /// <returns>El objeto original contenido en el Json.</returns>
        /// <exception cref="Ada.Framework.Data.Json.Exceptions.JsonConvertException"></exception>
        T ToObject<T>(string json, bool incluirTipo);
    }
}
