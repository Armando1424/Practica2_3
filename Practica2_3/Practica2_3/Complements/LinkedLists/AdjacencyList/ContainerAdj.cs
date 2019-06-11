using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_3.Complements.LinkedLists.AdjacencyList
{
    public class ContainerAdj
    {
        private NodoAdj primero;
        private int size;
        public ContainerAdj()
        {
            this.primero = null;
            this.size = 0;
        }

        public ContainerAdj(bool nosirve)
        { }

        public bool ListaVacia()//Revisa si hay datos
        {
            if (primero == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //public void addNodo(int Id, string lexema, string tipo, string lectura, string valor)//agrega nodo
        //{
        //    NodoAdj nuevo = new NodoAdj(Id,lexema,tipo,lectura,valor);
        //    nuevo.siguiente = primero;
        //    primero = nuevo;
        //    size++;
        //}

        public void addDiferentWayNodo(int Id, string lexema, string tipo, string lectura, string valor)
        {
            NodoAdj nuevo = new NodoAdj(Id, lexema, tipo, lectura, valor);
            NodoAdj valor1, valor2;
            if (primero == null)
            {
                primero = nuevo;
                nuevo.siguiente = null;
            }
            else
            {
                valor1 = primero;
                while (valor1 != null)
                {
                    valor2 = valor1.siguiente;
                    if (nuevo.Id <= valor1.Id)
                    {
                        nuevo.siguiente = primero;
                        primero = nuevo;
                        break;
                    }
                    else if (nuevo.Id > valor1.Id && valor2 == null)
                    {
                        valor1.siguiente = nuevo;
                        nuevo.siguiente = null;
                        break;
                    }
                    else if (valor1.Id < nuevo.Id && valor2.Id >= nuevo.Id)
                    {
                        valor1.siguiente = nuevo;
                        nuevo.siguiente = valor2;
                        break;
                    }
                    else
                    {
                        valor1 = valor1.siguiente;
                    }
                }
            }
            size++;
        }

        public void DeletePrimero()//de izquierda a derecha
        {
            primero = primero.siguiente;
        }

        public void DelateUltimo()//de izquierda a derecha
        {
            NodoAdj anterior = primero;
            NodoAdj actual = primero;
            while (actual.siguiente != null)
            {
                anterior = actual;
                actual = actual.siguiente;
            }
            anterior.siguiente = null;
        }

        public void DeletePosicionNodo(int p)//borra el nodo en la pocicion indicada
        {
            NodoAdj anterior = primero;
            NodoAdj actual = primero;
            int dato = 0;
            if (p > 0)
            {
                while (dato != p && actual.siguiente != null)
                {
                    anterior = actual;
                    actual = actual.siguiente;
                    dato++;
                }
                anterior.siguiente = actual.siguiente;
            }
        }

        public NodoAdj Buscar(string lexema)//retorna el nodo, no econtrado retorna null
        {
            NodoAdj p = primero;
            if (p == null)
            {
                //Console.WriteLine("La lista no contiene datos");
            }
            else
            {
                while (p.siguiente != null || p.siguiente == null)
                {
                    if (p.lexema == lexema)
                    {
                        return p;
                    }
                    else if (p.siguiente == null)
                    {
                        return null;
                    }
                    p = p.siguiente;
                }
            }
            return null;
        }

        public void SustituirValor(string origLexema, string valor)//Remplaza el dato
        {
            NodoAdj pos = Buscar(origLexema);
            if (pos != null || pos == null)
            {
                pos.valor = valor;
            }
        }
        public void SustituirLectura(string origLexema, string letura)//Remplazar el tipo
        {
            NodoAdj pos = Buscar(origLexema);
            if (pos != null || pos == null)
            {
                pos.lectura = letura;
            }
        }

        public int Size()//retorna el tamaño
        {
            return size;
        }

        public void Listar()//imprime los datos de la lista de izquierda a derecha
        {
            NodoAdj actual = primero;
            Console.WriteLine("Id    lexema            tipo         lectura  valor              ");
            while (actual != null)
            {
                Console.WriteLine(actual.Id + "      " + actual.lexema + "              " + actual.tipo + "           " + actual.lectura + "       " + actual.valor );
                actual = actual.siguiente;
            }
            Console.WriteLine();
        }
    }
}
