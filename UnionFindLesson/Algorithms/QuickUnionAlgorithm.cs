using UnionFindLesson.Interfaces;

namespace UnionFindLesson.Algorithms
{
    internal class QuickUnionAlgorithm : IUnionFindAlgorithm
    {
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

            unionFind._index[sourceRoot] = destinationRoot;

            unionFind._count--;
        }
    }
}
