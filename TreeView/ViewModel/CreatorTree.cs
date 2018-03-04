using System;

namespace TreeView.ViewModel
{
    public abstract class CreatorTree<T> where T: new()
    {
        protected Random random = new Random();

        public abstract Tree CreateTree();

        protected Tree CreateBranch()//Надо поработать над LeaveTree
        {
            Tree attachebleBranch = new T() as Tree;
            if (attachebleBranch is LeaveTree)
            {
                LeaveTree leaveTree = (LeaveTree)attachebleBranch;
                attachebleBranch.Element = leaveTree.ToString();
            }
            else
                attachebleBranch.Element = GetRandomString();
            for (int i = 0; i < random.Next(2, 10); i++)
            {
                attachebleBranch.Node.Add(new T() as Tree);
                if (attachebleBranch.Node[i] is LeaveTree)
                {
                    LeaveTree leaveTree = (LeaveTree)attachebleBranch.Node[i];
                    attachebleBranch.Node[i].Element = leaveTree.ToString();
                }
                else
                    attachebleBranch.Node[i].Element = GetRandomString();
            }
            return attachebleBranch;
        }

        protected string GetRandomString() => random.Next(0x0410, 0x44F).ToString();
    }
}
