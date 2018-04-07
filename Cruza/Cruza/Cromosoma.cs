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
    class Cromosoma{
        private int Num_Bits = 0;
        //Areglo de genes
        private int[] gene;
        //Funcion que determina el tamaño del arreglo de cromosoma
        public Cromosoma(int bits)
        {
            Num_Bits = bits;
            //Asignacion de espacios de memoria 
            gene = new int[Num_Bits];
        }

        
        //Funcion para concertir el numero en binario a decimal
        public double GetValue(){
            double value = 0;
            for (int j = 0; j < Num_Bits - 1; j++)
            {
                value += gene[Num_Bits - j - 1] * Math.Pow(2.0, j);
            }
            if (gene[0] == 1)
            {
                value = -value;
            }
            return value;
        }
        //Funcion para generar los valores de los genes
        public void inicializa() //Con esta funcion se llena el gen con numeros aleatorios
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int n;
            for (int i = 0; i < Num_Bits; i++)
            {
                n = random.Next(1, 3); //Se guarda temporalmente el numero generado
                if (n == 2) //Si es uno se agrega al gen en la posicion de i 
                {
                    gene[i] = 1;
                }
            }
        }
        //Ciclo para concatenar los valores de los genes en una cadema 

        public string getGene()
        {
            string g = "";
            for (int i = 0; i < Num_Bits; i++)
            {
                g += gene[i].ToString();
            }
            return g;
        }
        //funcion que retorna los valores de los genes 
        public int[] getvalor()
        {
            return gene;
        }

        public int tam()
        {
            return Num_Bits;
        }

    }
}
