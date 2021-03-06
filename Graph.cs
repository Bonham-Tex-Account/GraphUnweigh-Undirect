﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnweighedAndUndirected
{
    public class Vertex<T> where T : IComparable<T>
    {
        public T value { get; set; }
        public List<Vertex<T>> Neighbor { get; set; }
        public int NeighborCount => Neighbor.Count;
        public Vertex(T Value)
        {
            value = Value;
            Neighbor = new List<Vertex<T>>();
        }
    }
    public class Graph<T> where T : IComparable<T>
    {
        public List<Vertex<T>> Vertrcies { get; private set; }
        public int VerteciesCount => Vertrcies.Count;
        public Graph()
        {
            Vertrcies = new List<Vertex<T>>();
        }
        public void Add(Vertex<T> vertex)
        {
            if (Search(vertex.value) != null)
            {
                throw new Exception("No Duups");
            }
            else
            {
                Vertrcies.Add(vertex);
            }

        }
        public bool Remove(Vertex<T> vertex)
        {
            if (Search(vertex.value) != null)
            {
                Vertrcies.Remove(vertex);
                return true;
            }
            return false;
        }
        public bool AddEdege(Vertex<T> A, Vertex<T> B)
        {
            int a = GetIndex(A);
            int b = GetIndex(B);
            if (a!=-1&&b!=-1)
            {
                
                Vertrcies[a].Neighbor.Add(Vertrcies[b]);
                Vertrcies[b].Neighbor.Add(Vertrcies[a]);
                return true;
            }
            return false;
        }
        public bool RemoveEdge(Vertex<T> A, Vertex<T> B)
        {
            int a = GetIndex(A);
            int b = GetIndex(B);
            if (a != -1 && b != -1)
            {
                if (Vertrcies[a].Neighbor.Contains(Vertrcies[b]) && Vertrcies[b].Neighbor.Contains(Vertrcies[a]))
                {
                    Vertrcies[a].Neighbor.Remove(Vertrcies[b]);
                    Vertrcies[b].Neighbor.Remove(Vertrcies[a]);
                    return true;
                }
            }
            return false;
        }
        public Vertex<T> Search(T value)
        {
            for (int i = 0; i < VerteciesCount; i++)
            {
                if (value.CompareTo(Vertrcies[i].value) == 0)
                {
                    return Vertrcies[i];
                }
            }
            return null;
        }
        private int GetIndex(Vertex<T> vertex)
        {
            for (int i = 0; i < VerteciesCount; i++)
            {
                if (vertex.value.CompareTo(Vertrcies[i].value) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
