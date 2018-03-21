using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AbstractFactory.Factoires
{
   public class PurpleButtonFactory : AbstractFactory
   {
      private Button button;
      public int Left = 20;
      public int Top = 20;

      public override Button Create()
      {
         button = new Button();
         button.Click += this.ButonClick;
         button.Left = this.Left;
         button.Top = this.Top;
         button.Width = 100;
         button.Height = 40;
         button.BackColor = Color.Purple;
         button.Text = "Push me";
         return button;
      }

      public void ButonClick(object sender, EventArgs e)
      {
         MessageBox.Show("Its Greeeen");
      }

   }
}
