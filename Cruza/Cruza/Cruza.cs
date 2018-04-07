using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Universidad Autonoma del Estado de Mexico
 *    Centro Universitario Zumpango
 *      Ingenieria en Computacion
 *    Materia: Algoritmos Geneticos 
 * Realizado Por: Gómez Sánchez Brayan Omar
 *         Fecha: 28 de marzo 2018
 * https://github.com/brayangomezsanchez/AGCRUZA
 */

namespace Cruza
{
    class Cruza{
        public Cruza(){
            /*los numero toman en cuenta su signo*/
            //Declaramos los dos individuos que se van a cruzar 
            individuo padre1 = new individuo(8);
            individuo padre2 = new individuo(8);

            // ausiliares para hacer la cruza
            int[] aux1 = new int[padre1.tamin()];
            aux1 = padre1.getcromosoma();
            int[] aux2 = new int[padre2.tamin()];
            aux2 = padre2.getcromosoma();

            //Se imprime el primer Individuo 
            Console.WriteLine("Padre 1");
            Console.WriteLine(padre1.ToString());
            //se imprime el segundo individuo 
            Console.WriteLine("Padre 2");
            Console.WriteLine(padre2.ToString());

            //se declaran los hijos con el mismo valor que los padres 
            int[] hijo1 = new int[padre1.tamin()];
            int[] hijo2 = new int[padre2.tamin()];

            //comenzamos la cruza
            String cadena;
            int puntocruza;
            Console.WriteLine("Introdusca el punto de la cruza entere el 2 y 7");
            cadena = Console.ReadLine();
            puntocruza = int.Parse(cadena);
            if (puntocruza > 1 && puntocruza < 8)
            {
                for (int i = 0; i < padre1.tamin(); i++)
                {

                    if (i <= puntocruza)
                    {//Si el indice es <= al punto entonces se asignan las posiciones de cada hijo
                        hijo1[i] = aux1[i];
                        hijo2[i] = aux2[i];
                    }
                    else
                    {//si no entonces las posiciones seguiran de la misma manera
                        hijo1[i] = aux2[i];
                        hijo2[i] = aux1[i];
                    }
                }

                Console.WriteLine("\t La Cruza es:");
                Console.WriteLine("El punto de la cruza es: " + puntocruza);
                //parte que imprime al hijo1
                string h1 = "";
                //for para crear la caldena del hijo1
                for (int i = 0; i < padre1.tamin(); i++)
                {
                    h1 += hijo1[i].ToString();
                }
                Console.WriteLine("Hijo 1");
                Console.WriteLine("[" + h1 + "]");


                string h2 = "";
                //for para crear la caldena del hijo1
                for (int i = 0; i < padre1.tamin(); i++)
                {
                    h2 += hijo2[i].ToString();
                }
                Console.WriteLine("Hijo 2");
                Console.WriteLine("[" + h2 + "]");

            }else
                Console.WriteLine("Eerro punto de cruza fuera del rango");
                Console.WriteLine("Ejecute el programa nuevamente");
        }
    }
}
