using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharm
{
    public class RealClass : IProxy
    {
        public void checkType(Form form)
        {
            MessageBox.Show("welcome");
        }
    }
}
