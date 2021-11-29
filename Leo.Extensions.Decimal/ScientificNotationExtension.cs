using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leo.Extensions
{
    public static class ScientificNotationExtension
    {
        public static string ToScientificNotation(this int i, int precision = 2)
        {
            return i.ToString($"e{precision}");
        }

        public static string ToScientificNotation(this uint i, int precision = 2)
        {
            return i.ToString($"e{precision}");
        }

        public static string ToScientificNotation(this long l, int precision = 2)
        {
            return l.ToString($"e{precision}");
        }

        public static string ToScientificNotation(this ulong l, int precision = 2)
        {
            return l.ToString($"e{precision}");
        }

        public static string ToScientificNotation(this decimal d, int precision = 2)
        {
            return d.ToString($"e{precision}");
        }

        public static string ToScientificNotation(this float f, int precision = 2)
        {
            return f.ToString($"e{precision}");
        }

        public static string ToScientificNotation(this double d, int precision = 2)
        {
            return d.ToString($"e{precision}");
        }
    }
}
