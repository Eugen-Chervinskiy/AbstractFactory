namespace AbstractFactory
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
         this.button1 = new System.Windows.Forms.Button();
         this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
         this.button2 = new System.Windows.Forms.Button();
         this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
         this.button3 = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // materialSingleLineTextField1
         // 
         this.materialSingleLineTextField1.Depth = 0;
         this.materialSingleLineTextField1.Hint = "";
         this.materialSingleLineTextField1.Location = new System.Drawing.Point(80, 41);
         this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
         this.materialSingleLineTextField1.PasswordChar = '\0';
         this.materialSingleLineTextField1.SelectedText = "";
         this.materialSingleLineTextField1.SelectionLength = 0;
         this.materialSingleLineTextField1.SelectionStart = 0;
         this.materialSingleLineTextField1.Size = new System.Drawing.Size(99, 23);
         this.materialSingleLineTextField1.TabIndex = 1;
         this.materialSingleLineTextField1.UseSystemPasswordChar = false;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(65, 12);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(135, 23);
         this.button1.TabIndex = 0;
         this.button1.Text = "GreenButtonFactory";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // materialSingleLineTextField2
         // 
         this.materialSingleLineTextField2.Depth = 0;
         this.materialSingleLineTextField2.Hint = "";
         this.materialSingleLineTextField2.Location = new System.Drawing.Point(355, 41);
         this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
         this.materialSingleLineTextField2.PasswordChar = '\0';
         this.materialSingleLineTextField2.SelectedText = "";
         this.materialSingleLineTextField2.SelectionLength = 0;
         this.materialSingleLineTextField2.SelectionStart = 0;
         this.materialSingleLineTextField2.Size = new System.Drawing.Size(95, 23);
         this.materialSingleLineTextField2.TabIndex = 2;
         this.materialSingleLineTextField2.UseSystemPasswordChar = false;
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(335, 12);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(131, 23);
         this.button2.TabIndex = 1;
         this.button2.Text = "BlueButtonFactory";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // materialSingleLineTextField3
         // 
         this.materialSingleLineTextField3.Depth = 0;
         this.materialSingleLineTextField3.Hint = "";
         this.materialSingleLineTextField3.Location = new System.Drawing.Point(667, 50);
         this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
         this.materialSingleLineTextField3.PasswordChar = '\0';
         this.materialSingleLineTextField3.SelectedText = "";
         this.materialSingleLineTextField3.SelectionLength = 0;
         this.materialSingleLineTextField3.SelectionStart = 0;
         this.materialSingleLineTextField3.Size = new System.Drawing.Size(120, 23);
         this.materialSingleLineTextField3.TabIndex = 3;
         this.materialSingleLineTextField3.UseSystemPasswordChar = false;
         this.materialSingleLineTextField3.Click += new System.EventHandler(this.materialSingleLineTextField3_Click);
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(667, 12);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(128, 23);
         this.button3.TabIndex = 2;
         this.button3.Text = "PurpleButtonFactory";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(913, 623);
         this.Controls.Add(this.materialSingleLineTextField1);
         this.Controls.Add(this.materialSingleLineTextField2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.materialSingleLineTextField3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button3);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
      private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
      private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
   }
}

