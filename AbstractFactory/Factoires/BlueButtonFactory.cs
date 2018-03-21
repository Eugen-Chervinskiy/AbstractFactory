using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AbstractFactory.Factoires
{
   public class BlueButtonFactory : AbstractFactory
   {
      private Button button;
      public override Button Create()
      {
         button = new Button();
         button.Click += this.ButonClick;
         button.Left += 250;
         button.Top += 220;
         button.Width = 100;
         button.Height = 40;
         button.BackColor = Color.Blue;
         button.Text = "Push me";
         return button;
      }


      public void ButonClick(object sender, EventArgs e)
      {
         MessageBox.Show("Its Greeeen");
      }
   }
}
