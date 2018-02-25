using UnionFindLesson.Algorithms;
using UnionFindLesson.Interfaces;

namespace UnionFindLesson
{
    public class QuickFind : IUnionFind
    {
        private readonly IUnionFind _unionFind;

        public QuickFind(int vertices)
        {
            _unionFind = new UnionFind(vertices, new QuickFindAlgorithm());
        }

        public int Count()
        {
            return _unionFind.Count();
        }

        public bool IsConnected(int source, int destination)
        {
            return _unionFind.IsConnected(source, destination);
        }

        public int Find(int vertex)
        {
            return _unionFind.Find(vertex);
        }

        public void Union(int source, int destination)
        {
            _unionFind.Union(source, destination);
        }
    }
}
