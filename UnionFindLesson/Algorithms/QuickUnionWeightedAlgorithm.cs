using UnionFindLesson.Interfaces;

namespace UnionFindLesson.Algorithms
{
    internal class QuickUnionWeightedAlgorithm : IUnionFindAlgorithm
    {
        internal int[] _size;

        public QuickUnionWeightedAlgorithm(int vertices)
        {
            _size = new int[vertices];

            for (var i = 0; i < vertices; i++)
                _size[i] = 1;
        }

        public int Find(UnionFind unionFind, int vertex)
        {
            while (vertex != unionFind._index[vertex])
            {
                vertex = unionFind._index[vertex];
            }

            return vertex;
        }

        public void Union(UnionFind unionFind, int source, int destination)
        {
            var sourceRoot = Find(unionFind, source);
            var destinationRoot = Find(unionFind, destination);

            if (sourceRoot == destinationRoot)
                return;

            if (_size[sourceRoot] < _size[destinationRoot])
            {
                unionFind._index[sourceRoot] = destinationRoot;
                _size[destinationRoot] += _size[sourceRoot];
            }
            else
            {
                unionFind._index[destinationRoot] = sourceRoot;
                _size[sourceRoot] += _size[destinationRoot];
            }

            unionFind._count--;
        }
    }
}
