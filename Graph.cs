using System;
using System.Collections.Generic;
using System.Text;

namespace UnweighedAndUndirected
{
    public class Vertex<T>
    {
        public T value { get; set; }
        public List<Vertex<T>> Neighbor {get;set;}
        public int NeighborCount => Neighbor.Count;
        public Vertex(T Value)
        {
            value = Value;
        }
    }
    public class Graph<T>
    {
        public List<Vertex<T>> Vertrcies { get; private set; }
        public int VerteciesCount => Vertrcies.Count;
        public Graph()
        {

        }
        public void Add()
        {

        }
        public bool Remove()
        {

        }
        public bool AddEdege()
        {

        }
        public bool RemoveEdge()
        {

        }
        public Vertex<T> Search()
        {

        }

    }
}
