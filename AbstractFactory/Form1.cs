using AbstractFactory.Factoires;
using System;
using System.Windows.Forms;

namespace AbstractFactory
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
         
      }
      int top = 10;
      int left = 10;
      private void button1_Click(object sender, EventArgs e)
      {
         top++;
         left++;
         var greenFactory = new GreenButtonFactory();
         
            var btn = greenFactory.Create();
            btn.Top += top;
            btn.Left += left;

            this.Controls.Add(btn);
      }

      private void materialSingleLineTextField3_Click(object sender, EventArgs e)
      {

      }

      private void button2_Click(object sender, EventArgs e)
      {
         var blueFactory = new BlueButtonFactory();
         this.Controls.Add(blueFactory.Create());
      }

      private void button3_Click(object sender, EventArgs e)
      {
         var purpleFactory = new PurpleButtonFactory();
         this.Controls.Add(purpleFactory.Create());
      }

      public void PurpleButonnClick(object sender, EventArgs e)
      {
         var blueFactory = new BlueButtonFactory();
         this.Controls.Add(blueFactory.Create());
      }
   }
}
