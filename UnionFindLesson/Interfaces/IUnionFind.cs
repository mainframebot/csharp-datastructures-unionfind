namespace UnionFindLesson.Interfaces
{
    internal interface IUnionFind
    {
        int Count();

        bool IsConnected(int source, int destination);

        int Find(int vertex);

        void Union(int source, int destination);
    }
}
