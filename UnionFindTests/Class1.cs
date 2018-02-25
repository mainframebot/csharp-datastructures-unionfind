using NUnit.Framework;
using UnionFindLesson;

namespace UnionFindTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestingUFQuickFind()
        {
            var unionFind = new QuickFind(10);

            unionFind.Union(4, 3);
            unionFind.Union(3, 8);
            unionFind.Union(6, 5);
            unionFind.Union(9, 4);
            unionFind.Union(2, 1);
            unionFind.Union(8, 9);
            unionFind.Union(5, 0);
            unionFind.Union(7, 2);
            unionFind.Union(6, 1);
            unionFind.Union(1, 0);
            unionFind.Union(6, 7);
        }

        [Test]
        public void TestingUFQuickUnion()
        {
            var unionFind = new QuickUnion(10);

            unionFind.Union(4, 3);
            unionFind.Union(3, 8);
            unionFind.Union(6, 5);
            unionFind.Union(9, 4);
            unionFind.Union(2, 1);
            unionFind.Union(8, 9);
            unionFind.Union(5, 0);
            unionFind.Union(7, 2);
            unionFind.Union(6, 1);
            unionFind.Union(1, 0);
            unionFind.Union(6, 7);
        }

        [Test]
        public void TestingUFQuickUnionWeighted()
        {
            var unionFind = new QuickUnionWeighted(10);

            unionFind.Union(4, 3);
            unionFind.Union(3, 8);
            unionFind.Union(6, 5);
            unionFind.Union(9, 4);
            unionFind.Union(2, 1);
            unionFind.Union(8, 9);
            unionFind.Union(5, 0);
            unionFind.Union(7, 2);
            unionFind.Union(6, 1);
            unionFind.Union(1, 0);
            unionFind.Union(6, 7);
        }
    }
}
