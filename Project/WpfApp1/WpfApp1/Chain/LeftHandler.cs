using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Chain
{
    class LeftHandler : Handler
    {
        public override void HandleRequest(Thickness requestA, Thickness requestB)
        {
            if (requestA.Left < -200 || requestB.Left < -200)
            {
                System.Windows.Application.Current.Shutdown();
            }
            else if (successor != null)
            {
                successor.HandleRequest(requestA, requestB);
            }
        }
    }
}
