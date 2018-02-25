using UnionFindLesson.Interfaces;

namespace UnionFindLesson.Algorithms
{
    internal class QuickFindAlgorithm : IUnionFindAlgorithm
    {
        public int Find(UnionFind unionFind, int vertex)
        {
            return unionFind._index[vertex];
        }

        public void Union(UnionFind unionFind, int source, int destination)
        {
            var sourceIndex = Find(unionFind, source);
            var destinationIndex = Find(unionFind, destination);

            if (sourceIndex == destinationIndex)
                return;

            for (var i = 0; i < unionFind._index.Length; i++)
            {
                if (unionFind._index[i] == sourceIndex)
                    unionFind._index[i] = destinationIndex;
            }

            unionFind._count--;
        }
    }
}
