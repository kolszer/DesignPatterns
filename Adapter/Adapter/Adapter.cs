using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adapter : HTMLAdapter
    {
        public Func<string, string> Request;

        public Adapter(HTMLAdapter hTMLAdapter)
        {
            Request = hTMLAdapter.ToHTML;
        }

        public Adapter(MDAdapter mDAdapter)
        {
            Request = mDAdapter.ToMD;
        }

        public void ChangeRequest(Func<string, string> ff)
        {
            Request = ff;
        }
    }
}
