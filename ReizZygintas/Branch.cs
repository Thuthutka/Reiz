using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReizZygintas
{
    class Branch
    {
       public List<Branch> branches = new List<Branch>();
       public string _data;

        public Branch(string data)
        {
            _data = data;
        }

       public int Depth
        {
            get
            {
                int depth = 0;
                foreach (Branch branch in branches)
                {
                    var descendantDepth = branch.Depth;
                    if (descendantDepth > depth)
                        depth = descendantDepth;
                }
                depth++;
                Console.WriteLine($"{_data} -- {depth}");
                return depth;
            }
        }
    }
}
