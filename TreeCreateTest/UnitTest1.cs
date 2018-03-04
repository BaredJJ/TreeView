using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeView.ViewModel;

namespace TreeCreateTest
{
    [TestClass]
    public class UnitTest1
    {
        CreatorTree<BranchTree> creator = new CreateOnlyBranch();

        Tree tree; 

        [TestMethod]
        public void TestMethod1()
        {
            tree = creator.CreateTree();

            Print();

            Assert.IsTrue(tree.Node != null);
        }

        private void Print()
        {
            PrintElement(0, tree);
        }

        private void PrintElement(int shift, Tree element)
        {
            BranchTree temp = element as BranchTree;
            Console.WriteLine("{0}{1}", new string(' ', shift), temp.BranchValue);
            foreach (var child in element.Node)
            {
                PrintElement(shift + 2, child);
            }
        }
    }
}
