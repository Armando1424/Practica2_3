namespace Practica2_3.Complements.LinkedLists.InformationList
{
    using Practica2_3.Complements.LinkedLists.AdjacencyList;
    public class NodoInf
    {
        public int Id;
        public string info, void1, void2;
        public NodoInf siguiente;
        public NodoAdj FirstAdj;
        public NodoInf(int Id, string info, string void1, string void2)
        {
            this.Id = Id;
            this.info = info;
            this.void1 = void1;
            this.void2 = void2;
            this.siguiente = null;
            this.FirstAdj = null;
        }
    }
}
