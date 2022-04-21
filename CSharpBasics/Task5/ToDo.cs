using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class ToDo
    {
        public string Title{ get; set; }
        public bool IsDone { get; set; }
        
        public ToDo()
        {
            Title = "";
            IsDone = false;
        }

        public ToDo(string title)
        {
            Title = title;
            IsDone = false;
        }

        public void Print()
        {
            Console.WriteLine(Title);
            if (IsDone)
            {
                Console.Write(" [x]");
            }
        }

        public void Done()
        {
            IsDone = true;
        }
    }
}
