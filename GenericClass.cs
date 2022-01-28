using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_hometask
{
    class GenericClass<T>
    {
        private string delegateMessage;
        public GenericClass(Delegate3<T> del3)
        {
            delegateMessage = del3.ToString();
        }

        public static void Execute(Delegate3<string> del3)
        {
            del3.Invoke("gg");
        }
    }
}
