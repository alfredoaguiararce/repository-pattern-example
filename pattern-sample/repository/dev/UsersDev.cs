using pattern_sample.abtractions;

namespace pattern_sample.repository.dev
{
    /*
        Al implmentar la clase abstracta se tiene el contrato-interfaz necesaaria de los metodos que comparten ambos ambientes
        pero al tratarse de clases diferentes tanto UsersDev como UsersTraining pueden implmeentar estos metodos de manera diferente 
        mientras estos cumplan con los resultados esperados por el contrato
     */
    internal class UsersDev : UsersBase
    {

        public override void metodo_1()
        {
            // por ejemplo para dev el codigo del metodo 1 puede ser 
            int a = 1;
            int b = 2;
            int c = a + b;
        }

        public override void metodo_2()
        {
            throw new NotImplementedException();
        }

        public override void metodo_3()
        {
            throw new NotImplementedException();
        }
    }
}
