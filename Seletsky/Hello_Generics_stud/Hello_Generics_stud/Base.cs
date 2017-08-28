using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_Generics_stud
{

    public static class Curry_list
    {

        public static Func<TArg2, Func<TArg1, TResult>> Bnd<TArg1, TArg2, TResult>(this Func<TArg1, TArg2, TResult> f)
        {
            return (y) => ((x) => f(x, y));
        }
    }

    class Base
    {
    }
}
