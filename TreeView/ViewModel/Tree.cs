using System;
using System.Collections.ObjectModel;

namespace TreeView.ViewModel
{
    public abstract class Tree
    {
        protected Random random = new Random();

        ObservableCollection<Tree> _node = new ObservableCollection<Tree>();

        protected string _element;

        public ObservableCollection<Tree> Node
        {
            get => _node;

            set { _node = value; }
        }

        public virtual string Element
        {
            get => _element;
            set { _element = value; }
        }      
    }
}
