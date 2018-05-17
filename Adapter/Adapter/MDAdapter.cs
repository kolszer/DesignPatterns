using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MDAdapter
    {
        public string ToMD(string x)
        {
            string res = "";
            int i = -1;
            string asd = new String(x.Take(7).ToArray());
            string zxc = x.Substring(x.Length - 7);
            if (new String(x.Take(7).ToArray()) == "<body>\n" && x.Substring(x.Length - 7) == "</body>")
            {
                x = new String(x.Take(x.Length - 7).ToArray()).Substring(7);
            }
            else
            {
                return "";
            }

            using (StringReader reader = new StringReader(x))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (new String(line.Take(3).ToArray()) == "<p>" && line.Substring(line.Length - 4) == "</p>")
                    {
                        string tmp = new String(line.Take(line.Length - 4).ToArray()).Substring(3);
                        res += ">" + tmp + "\n";
                    }
                    else if (new String(line.Take(4).ToArray()) == "<h1>" && line.Substring(line.Length - 5) == "</h1>")
                    {
                        string tmp = new String(line.Take(line.Length - 5).ToArray()).Substring(4);
                        res += "###" + tmp + "\n";
                    }
                    else if (new String(line.Take(4).ToArray()) == "<ul>")
                    {
                        i = 0;
                    }
                    else if (new String(line.Take(4).ToArray()) == "<li>" && line.Substring(line.Length - 5) == "</li>")
                    {
                        i++;
                        string tmp = new String(line.Take(line.Length - 5).ToArray()).Substring(4);
                        res += i.ToString() + "." + tmp + "\n";
                    }
                }
            }
            return res;
        }
    }
}
