using System;
using UnionFindLesson.Interfaces;

namespace UnionFindLesson
{
    internal class UnionFind : IUnionFind
    {
        private readonly IUnionFindAlgorithm _algorithm;

        internal int[] _index;
        internal int _count;

        public UnionFind(int vertices, IUnionFindAlgorithm algorithm)
        {
            if(algorithm == null)
                throw new ArgumentNullException();

            _algorithm = algorithm;

            _count = vertices;
            _index = new int[vertices];

            for (var i = 0; i < vertices; i++)
                _index[i] = i;
        }

        public int Count()
        {
            return _count;
        }

        public int Find(int vertex)
        {
            Validate(vertex);

            return _algorithm.Find(this, vertex);
        }

        public bool IsConnected(int source, int destination)
        {
            Validate(source);
            Validate(destination);

            return _algorithm.Find(this, source) == _algorithm.Find(this, destination);
        }

        public void Union(int source, int destination)
        {
            Validate(source);
            Validate(destination);

            _algorithm.Union(this, source, destination);
        }

        private void Validate(int vertex)
        {
            if(vertex < 0 || vertex >= _index.Length)
                throw new ArgumentOutOfRangeException();
        }
    }
}
