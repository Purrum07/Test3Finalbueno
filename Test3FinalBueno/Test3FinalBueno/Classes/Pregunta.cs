using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3FinalBueno.Classes
{
    class Pregunta
    {
        string nombre;
        string apellido;

        public void pre()
        {
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();

            

            Console.WriteLine("Escribe tu apellido");
            apellido = Console.ReadLine();

            try
            {
                if (nombre.Length  <= 2 )
                {
                    throw new System.ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("nombre no válido");
            }

            try
            {
                if (apellido.Length <= 2)
                {
                    throw new System.ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("apellido no válido");
            }


        }

    }
        
}
