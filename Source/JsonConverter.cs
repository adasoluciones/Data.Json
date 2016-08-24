using Ada.Framework.Data.Json.Exceptions;
using Newtonsoft.Json;

namespace Ada.Framework.Data.Json
{
    /// <summary>
    /// Representa el componente encargado de transformar objetos en Json y biseversa.
    /// </summary>
    /// <remarks>
    ///     Registro de versiones:
    ///     
    ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
    /// </remarks>
    internal class JsonConverter : IJsonConverter
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
        public string ToJson(object objeto)
        {
            return ToJson(objeto, true);
        }

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
        public string ToJson(object objeto, bool incluirTipo)
        {
            if (objeto == null) return null;

            try
            {
                if (incluirTipo)
                {
                    return JsonConvert.SerializeObject(objeto, GetJsonSettings());
                }

                return JsonConvert.SerializeObject(objeto);
            }
            catch (JsonSerializationException e)
            {
                throw new JsonConvertException(e.Message, e);
            }
        }

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
        public T ToObject<T>(string json)
        {
            return ToObject<T>(json, true);
        }
        
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
        public T ToObject<T>(string json, bool incluirTipo)
        {
            if (json == null) return default(T);

            try
            {
                if (incluirTipo)
                {
                    return JsonConvert.DeserializeObject<T>(json, GetJsonSettings());
                }

                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (JsonSerializationException e)
            {
                throw new JsonConvertException(e.Message, e);
            }
        }

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
        public object ToObject(string json)
        {
            return ToObject(json, true);
        }

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
        public object ToObject(string json, bool incluirTipo)
        {
            if (json == null) return null;

            try
            {
                if (incluirTipo)
                {
                    return JsonConvert.DeserializeObject(json, GetJsonSettings());
                }

                return JsonConvert.DeserializeObject(json);
            }
            catch (JsonSerializationException e)
            {
                throw new JsonConvertException(e.Message, e);
            }
        }

        /// <summary>
        /// Método que retorna la configuración de serialización a utilizar para la transformación.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        /// <returns>Configuración de serialización.</returns>
        private JsonSerializerSettings GetJsonSettings()
        {
            return new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
        }
    }
}
