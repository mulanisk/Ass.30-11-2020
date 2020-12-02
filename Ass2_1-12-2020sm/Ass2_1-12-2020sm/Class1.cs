using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2_1_12_2020sm
{
    class BankOps
    {
       
            public int NetBalance { get; set; }
        
            public void Overbalance(int p)
            {
            
                double tax = p * 0.18;
                System.Windows.Forms.MessageBox.Show("The Total amount to be paid is " + tax);

            }
            public void Underblance()
            {
                System.Windows.Forms.MessageBox.Show("Please maintain the minimum balance amount of Rs.5000");
            }
        }
}
