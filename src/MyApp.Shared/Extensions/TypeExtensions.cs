using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Shared.Extensions
{
    public static class TypeExtensions
    {
        public static bool IsAssignableTo<T>(this Type fromType)
        {
            return typeof(T).IsAssignableFrom(fromType);
        }
    }
}
