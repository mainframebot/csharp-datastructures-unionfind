namespace UnionFindLesson.Interfaces
{
    internal interface IUnionFindAlgorithm
    {
        int Find(UnionFind unionFind, int vertex);

        void Union(UnionFind unionFind, int source, int destination);
    }
}
