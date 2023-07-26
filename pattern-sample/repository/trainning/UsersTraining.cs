using pattern_sample.abtractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_sample.repository.trainning
{
    internal class UsersTraining : UsersBase
    {
        public override void metodo_1()
        {
            // por ejemplo para dev el codigo del metodo 1 puede ser 
            //int a = 1;
            //int b = 2;
            //int c = a + b;

            // Pero para training podria ser
            int a = 1;
            int b = 2;
            int c = a * b;

            // esto no interfiere ya que se cumple con el contrato de la interfaz sin embargo 
            /*
                Esto pudiera ser mas complejo
                como el manejo de dos ambientes donde por ejemplo en dev se usara entity framework y en training se usara Dapper 
             */
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
