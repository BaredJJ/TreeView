namespace TreeView.ViewModel
{
    public class CreateOnlyBranch : CreatorTree<BranchTree>
    {
        public override Tree CreateTree()
        {
            Tree finalyTree = new BranchTree();
            for(int i = 0; i < random.Next(100, 1000); i++)
            {
                finalyTree.Node.Add(new BranchTree() { Element = GetRandomString() });
                finalyTree.Node[i].Node.Add(CreateBranch());
                for (int k = 0; k < finalyTree.Node[i].Node.Count; k++)
                {
                   finalyTree.Node[i].Node[k].Node.Add(CreateBranch());
                   for (int m = 0; m < finalyTree.Node[i].Node[k].Node.Count; m++)
                   {
                      finalyTree.Node[i].Node[k].Node[m].Node.Add(CreateBranch());
                   }
                }
            }
            return finalyTree;
        }     
    }
}
