using System.Text;

namespace TreeView.ViewModel
{
    public class LeaveTree:Tree
    {
        int _id;

        string _name;

        double _data;

        public int Id => _id;

        public string Name => _name;

        public double Data => _data;

        public override string Element
        {
            get
            {
                return _element;
            }

            set
            {
                _element = ToString();
            }
        }

        //public LeaveTree()
        //{
        //    _id = random.Next(0, 100);
        //    _name = GetRandomString();
        //    _data = random.NextDouble();
        //    Element = ToString();

        //}

        private string GetRandomString()//Надо его куда то одельно определить повторяется в двух методах
        {
            StringBuilder temp = new StringBuilder();
            for(int i = 0; i < random.Next(5,20); i++)
            {
                temp.Append((char)random.Next(0x0410, 0x44F));
            }

            return temp.ToString();
        }

        public override string ToString()
        {
            _id = random.Next(0, 100);
            _name = GetRandomString();
            _data = random.NextDouble();
            return string.Format(Id.ToString() + " " + Name + " " + Data.ToString());
        }
    }
}
