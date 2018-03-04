using System.Collections.ObjectModel;


namespace TreeView.ViewModel
{
    //public class Temp : MainWindowViewModel.Node
    //{
        //static ObservableCollection<MainWindowViewModel.Node> _nodes2;
        //static Temp()
        //{
        //    _nodes2 = new Temp().Create();
        //}

        //public Temp()
        //{
        //    Nodes = _nodes2;
        //}

        //public override ObservableCollection<MainWindowViewModel.Node> Create()
        //{
        //    return new ObservableCollection<MainWindowViewModel.Node>
        //        {
        //            new Temp()
        //            {
        //                Id = 1,
        //                Name ="Европа",
        //                Data = 0.1111111111111,
        //               Nodes = new ObservableCollection<MainWindowViewModel.Node>
        //                {
        //                    new Temp {Id = 8, Name="Германия", Data = 0.12387123612 },
        //                    new Temp {Id = 2, Name="Франция", Data = 0.34324322 },
        //                    new Temp
        //                    {
        //                        Id = 9,
        //                        Name ="Великобритания",
        //                        Data = 12.4353452321321,
        //                        Nodes = new ObservableCollection<MainWindowViewModel.Node>
        //                        {
        //                            new Temp {Id = 0, Name="Англия", Data = 98.32234 },
        //                            new Temp {Id = 6, Name="Шотландия", Data = 8.123123 },
        //                            new Temp {Id = 5, Name="Уэльс", Data = 9.21312213 },
        //                            new Temp {Id = 3, Name="Сев. Ирландия", Data  = 0.21388254562},
        //                        }
        //                    }
        //                }
        //            },
        //            new Temp
        //            {
        //                Id = 89,
        //                Name ="Азия",
        //                Data = 0.21388213,
        //                Nodes = new ObservableCollection<MainWindowViewModel.Node>
        //                {
        //                    new Temp {Id = 56, Name="Китай", Data = 0.2139821 },
        //                    new Temp {Id = 76, Name="Япония", Data = 0.342234 },
        //                    new Temp {Id = 788, Name ="Индия", Data = 0.213562 }
        //                }
        //            },
        //            new Temp { Id = 12, Name="Африка", Data = 0.21321323 },
        //            new Temp {Id = 56, Name="Америка", Data = 0.213123124334 },
        //            new Temp { Id = 98, Name="Австралия", Data = 0.12398736 }
        //        };
        //}
    //}

    public class MainWindowViewModel
    {
        //Node _nodes;

        //public string Name
        //{
        //    get => _nodes.Name;
        //    set { _nodes.Name = value; }
        //}

        //public ObservableCollection<Node> Nodes
        //{
        //    get => _nodes.Nodes;
        //    set { _nodes.Nodes = value; }
        //}

        //public abstract class Node
        //{
        //    string _name;

        //    ObservableCollection<Node> _nodes;

        //    public int Id { get; set; }

        //    public string Name { get => _name; set { _name = value; } }

        //    public double Data { get; set; }

        //    public ObservableCollection<Node> Nodes { get => _nodes; set { _nodes = value; } }

        //    public abstract ObservableCollection<Node> Create();
        //}

        //public MainWindowViewModel()
        //{
        //    _nodes = new Temp();
        //}

        Tree _tree;

        bool _treeViewIsVirtualizing = true;

        bool _treeListIsVirtualizing = true;

        public ObservableCollection<Tree> Node
        {
            get => _tree.Node;
            set
            {
                _tree.Node = value;
            }
        }

        public bool TreeViewIsVirtualizing
        {
            get => _treeViewIsVirtualizing;

            set { _treeViewIsVirtualizing = value; }
        }

        public bool TreeListIsVirtualizing
        {
            get => _treeListIsVirtualizing;

            set { _treeListIsVirtualizing = value; }
        }

        public MainWindowViewModel()
        {
            CreatorTree<BranchTree> creatorTree = new CreateBranchAndLeave();

            _tree = creatorTree.CreateTree();
        }
    }
}
