using System;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractFactory.Factoires
{
   public class GreenButtonFactory : AbstractFactory
   {
      private Button button;
      public int Left = 20;
      public int Top = 20;
      public GreenButtonFactory()
      {
         
      }

      public override Button Create()
      {
         button = new Button();
         button.Click += this.ButonClick;
         button.Size = new Size(151, 51);
         button.Left = Left;
         button.Top = Top;
         button.BackColor = Color.Green;
         button.Text = "Push me";
         return button;
      }

      
      public void ButonClick(object sender, EventArgs e)
      {
         MessageBox.Show("Its Greeeen");
      }
   }
}
