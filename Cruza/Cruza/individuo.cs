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
 */

namespace Cruza
{
    class individuo{
        Cromosoma cromosoma;
            public individuo(int num_bits){
            //manda el numro de Bits que va a tener el cromosoma 
            cromosoma = new Cromosoma(num_bits);
            cromosoma.inicializa();
        }

        //Funcion que retorna una cadena con el gen en codigo binario 
        public override string ToString()
        {
            return string.Format("["+ cromosoma.getGene()  + "]\n");
        }
        //funcion que retorna el valos del cromosoma 
        public int[] getcromosoma() {

            return cromosoma.getvalor();
        }

        public int tamin() {
            return cromosoma.tam();
        }

    }
}
