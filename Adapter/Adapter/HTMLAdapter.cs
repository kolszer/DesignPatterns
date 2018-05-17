using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class HTMLAdapter
    {
        public string ToHTML(string x)
        {
            string res = "<body>\n";
            int state = 0;
            using (StringReader reader = new StringReader(x))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (state == 1 && !char.IsDigit(line[0]))
                    {
                        state = 0;
                        res += "</ul>\n";
                    }

                    if (line[0] == '>')
                    {
                        res += "<p>" + line.Substring(1) + "</p>\n";
                    }
                    else if (new String(line.Take(3).ToArray()) == "###")
                    {
                        res += "<h1>" + line.Substring(3) + "</h1>\n";
                    }
                    else if (char.IsDigit(line[0]) && line[1] == '.')
                    {
                        if (state == 0)
                        {
                            state = 1;
                            res += "<ul>\n";
                        }
                        res += "<li>" + line.Substring(2) + "</li>\n";
                    }
                }
            }
            return res + "</body>\n";
        }
    }
}
