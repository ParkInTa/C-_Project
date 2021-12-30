using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iotApp1005.Util
{
    static class ParsingData
    {
        private static void reDim(ref string[] ary)
        {
            int i = ary.Length;
            Array.Resize(ref ary, i + 1);
            ary[i] = null;
        }

        private static string[] parsingAll(string str,
            string strStart, string strEnd)
        {
            string source = str;
            string[] result = { null };
            int count = 0;
            while (source.IndexOf(strStart) > -1)
            {
                reDim(ref result);
                source = source.Substring(source.IndexOf(strStart) +
                    strStart.Length);
                if (source.IndexOf(strEnd) != -1)
                {
                    result[count] = source.Substring(0,
                        source.IndexOf(strEnd));
                }
                else
                {
                    return result;
                }
                count++;
            }
            return result;
        }

        private static string parsingFirst(string str,
            string strStart, string strEnd)
        {
            string source = str;
            source = source.Substring(
                source.IndexOf(strStart) + strStart.Length);
            string result = 
                source.Substring(0, source.IndexOf(strEnd));
            return result;
        }

        public static string[] parseAllWord(string src, string first,
            string end)
        {
            return parsingAll(src, first, end);
        }

        public static string parseFirstWord(string src, string first,
            string end)
        {
            return parsingFirst(src, first, end);
        }
    }
}
