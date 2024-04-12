using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimpleFactory
{
    public static class StringExtensions
    {
        public static string SplitPascalCaseString(this string pascalCaseString)
        {
            var modifiedCharacters = pascalCaseString
                .SelectMany((c, i) => i != 0 && char.IsUpper(c) && !char.IsUpper(pascalCaseString[i - 1])
                    ? new char[] { ' ', c } : new char[] { c });

            return new string(modifiedCharacters.ToArray());
        }
    }
}
