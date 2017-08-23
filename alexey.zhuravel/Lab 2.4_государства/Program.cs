using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using States.States;

namespace States
{
    class Program
    {
        static void Main(string[] args)
        {
            dbOfStates db = new dbOfStates();
            db.Iterate();


        }
    }
}
