using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6Practice
{
    
    public class MyModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public object Car { get; set; }
        public MyCategory MyCategory { get; set; }
    }

    public class MyCategory
    {
        public string Somefield { get; set; }
        public int Someint { get; set; }
    }

    //public string DoWork(int someParam)
    //{
    //    if (someParam < 0)
    //    {
    //        if(2 == 2)
    //        {
    //            if (3 == 3)
    //            {
    //                //...
    //            }
    //        }
    //    }
    //    else
    //    {
    //        return someParam.ToString();
    //    }
    //}

}
