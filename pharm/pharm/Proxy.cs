using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharm
{
    public class Proxy : IProxy
    {
        RealClass Real = new RealClass();
        public void showPage(Form logging)
        {
            Form1 s4 = new Form1();
            s4.Show();
            logging.Hide();
        }
        public void checkType(Form form)
        {
          Real.checkType(form);
         showPage(form);
         

        }
    }
}
