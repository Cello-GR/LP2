namespace ATIVIDADE6
{
    partial class Form2
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
            btn_executar = new Button();
            lstNomes = new ListBox();
            SuspendLayout();
            // 
            // btn_executar
            // 
            btn_executar.Location = new Point(67, 130);
            btn_executar.Name = "btn_executar";
            btn_executar.Size = new Size(170, 136);
            btn_executar.TabIndex = 0;
            btn_executar.Text = "Executar";
            btn_executar.UseVisualStyleBackColor = true;
            btn_executar.Click += btn_executar_Click;
            // 
            // lstNomes
            // 
            lstNomes.FormattingEnabled = true;
            lstNomes.ItemHeight = 25;
            lstNomes.Location = new Point(383, 50);
            lstNomes.Name = "lstNomes";
            lstNomes.Size = new Size(280, 329);
            lstNomes.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstNomes);
            Controls.Add(btn_executar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_executar;
        private ListBox lstNomes;
    }
}