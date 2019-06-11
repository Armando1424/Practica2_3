using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_3.Complements.LinkedLists.AdjacencyList
{
    public class NodoAdj
    {
        public int Id, peso, valHeu;
        public string void1;
        public NodoAdj siguiente;
        public NodoAdj(int Id, string void1, int peso, int valHeu)
        {
            this.Id = Id;
            this.void1 = void1;
            this.peso = peso;
            this.valHeu = valHeu;
            this.siguiente = null;
        }
    }
}
