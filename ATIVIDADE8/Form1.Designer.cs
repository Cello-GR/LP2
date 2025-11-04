namespace ATIVIDADE6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnEx4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(79, 43);
            button1.Name = "button1";
            button1.Size = new Size(208, 61);
            button1.TabIndex = 0;
            button1.Text = "Exercicio 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(338, 43);
            button2.Name = "button2";
            button2.Size = new Size(176, 61);
            button2.TabIndex = 1;
            button2.Text = "Exercicio 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(79, 133);
            button3.Name = "button3";
            button3.Size = new Size(208, 61);
            button3.TabIndex = 2;
            button3.Text = "Exercicio 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnEx4
            // 
            btnEx4.Location = new Point(338, 133);
            btnEx4.Name = "btnEx4";
            btnEx4.Size = new Size(176, 61);
            btnEx4.TabIndex = 3;
            btnEx4.Text = "Exercicio 4";
            btnEx4.UseVisualStyleBackColor = true;
            btnEx4.Click += btnEx4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEx4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnEx4;
    }
}
