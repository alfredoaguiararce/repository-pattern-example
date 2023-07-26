using pattern_sample.Models;

namespace pattern_sample.abtractions
{
    /*
     Esta clase contiene los metodos base que todas las clases derivadas en el repositorio contienen estas
    deberian contener los mismos metodos por ejemplo:

    Imaginemos tener 2 ambientes de desarrollo 'Dev' y 'Training'
    ambos ambientes poseen los metodos siquientes :
        - metodo 1
        - metodo 2
        - metodo 3

    que puedan ser del tipo cualquiera...

    * es preferible utilizar una interfaz para que de esta forma podamos utilizar inyeccion de dependencias
    * a su vez usamos esta interfaz sobre una clase abstracta que implementa de forma abstracta la interfaz
    * con el motivo de que cualquier clase que herede la clase base siga con el contrato (interfaz) y asi todas contengan los mismos metodos 
     */
    public abstract class UsersBase : IUsers
    {
        public abstract void metodo_1();
        public abstract void metodo_2();
        public abstract void metodo_3();
    }

    public interface IUsers
    {
        void metodo_1();
        void metodo_2();
        void metodo_3();
        //Others methods

    }
}
