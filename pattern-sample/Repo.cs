using Microsoft.Extensions.DependencyInjection;
using pattern_sample.abtractions;
using pattern_sample.repository.dev;
using pattern_sample.repository.trainning;

namespace pattern_sample
{
    public static class Repo
    {
        /// <summary>
        /// This function is used to inject the connection string into the constructor of the class
        /// </summary>
        /// <param Name="IServiceCollection">This is the service collection that is used to register
        /// services in an application.</param>
        public static void AddPattern(this IServiceCollection services, ENVIROMENT EnviromentType)
        {


            /* Dependencies injection for the development repository. */
            if (EnviromentType == ENVIROMENT.DEVELOPMENT)
            {
                // Implementar las clases de DEV pero siguiendo el contrato
                services.AddScoped<IUsers>(x => new UsersDev());
            }

            if (EnviromentType == ENVIROMENT.TRAINNING)
            {
                // Implementar las clases de TRAINING pero siguiendo el contrato
                services.AddScoped<IUsers>(x => new UsersTraining());
            }

            /*
             * Al final dado que todas las clases son de tipo internal
             * Solo se expondran las interfaces a la capa del usario pero al inyectarse con su devida clase ya sea DEV o TRAINING 
             * el usuario puede obtener el metodo siguiendo el contrato con direntes resultados si es deseado o diferentes fuentes de datos
             * ya sea dos diferentes bases de datos por ejemplo etc.
             */
        }
    }

    // Use this enum to only acepts the predifinied values
    public enum ENVIROMENT
    {
        DEVELOPMENT = 1,
        TRAINNING = 2
    }
}