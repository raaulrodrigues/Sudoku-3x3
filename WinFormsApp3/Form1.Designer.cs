namespace WinFormsApp3
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
            txtBx1 = new TextBox();
            txtBx2 = new TextBox();
            txtBx3 = new TextBox();
            txtBx6 = new TextBox();
            txtBx5 = new TextBox();
            txtBx4 = new TextBox();
            txtBx9 = new TextBox();
            txtBx8 = new TextBox();
            txtBx7 = new TextBox();
            btnIniciar = new Button();
            btnRevisar = new Button();
            SuspendLayout();
            // 
            // txtBx1
            // 
            txtBx1.Location = new Point(94, 98);
            txtBx1.Multiline = true;
            txtBx1.Name = "txtBx1";
            txtBx1.Size = new Size(45, 43);
            txtBx1.TabIndex = 0;
            // 
            // txtBx2
            // 
            txtBx2.Location = new Point(145, 98);
            txtBx2.Multiline = true;
            txtBx2.Name = "txtBx2";
            txtBx2.Size = new Size(45, 43);
            txtBx2.TabIndex = 1;
            // 
            // txtBx3
            // 
            txtBx3.Location = new Point(196, 98);
            txtBx3.Multiline = true;
            txtBx3.Name = "txtBx3";
            txtBx3.Size = new Size(45, 43);
            txtBx3.TabIndex = 2;
            // 
            // txtBx6
            // 
            txtBx6.Location = new Point(196, 147);
            txtBx6.Multiline = true;
            txtBx6.Name = "txtBx6";
            txtBx6.Size = new Size(45, 43);
            txtBx6.TabIndex = 5;
            // 
            // txtBx5
            // 
            txtBx5.Location = new Point(145, 147);
            txtBx5.Multiline = true;
            txtBx5.Name = "txtBx5";
            txtBx5.Size = new Size(45, 43);
            txtBx5.TabIndex = 4;
            // 
            // txtBx4
            // 
            txtBx4.Location = new Point(94, 147);
            txtBx4.Multiline = true;
            txtBx4.Name = "txtBx4";
            txtBx4.Size = new Size(45, 43);
            txtBx4.TabIndex = 3;
            // 
            // txtBx9
            // 
            txtBx9.Location = new Point(196, 196);
            txtBx9.Multiline = true;
            txtBx9.Name = "txtBx9";
            txtBx9.Size = new Size(45, 43);
            txtBx9.TabIndex = 8;
            // 
            // txtBx8
            // 
            txtBx8.Location = new Point(145, 196);
            txtBx8.Multiline = true;
            txtBx8.Name = "txtBx8";
            txtBx8.Size = new Size(45, 43);
            txtBx8.TabIndex = 7;
            // 
            // txtBx7
            // 
            txtBx7.Location = new Point(94, 196);
            txtBx7.Multiline = true;
            txtBx7.Name = "txtBx7";
            txtBx7.Size = new Size(45, 43);
            txtBx7.TabIndex = 6;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(38, 12);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(111, 80);
            btnIniciar.TabIndex = 9;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnRevisar
            // 
            btnRevisar.Location = new Point(183, 12);
            btnRevisar.Name = "btnRevisar";
            btnRevisar.Size = new Size(132, 80);
            btnRevisar.TabIndex = 11;
            btnRevisar.Text = "Revisar";
            btnRevisar.UseVisualStyleBackColor = true;
            btnRevisar.Click += btnRevisar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 294);
            Controls.Add(btnRevisar);
            Controls.Add(btnIniciar);
            Controls.Add(txtBx9);
            Controls.Add(txtBx8);
            Controls.Add(txtBx7);
            Controls.Add(txtBx6);
            Controls.Add(txtBx5);
            Controls.Add(txtBx4);
            Controls.Add(txtBx3);
            Controls.Add(txtBx2);
            Controls.Add(txtBx1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBx1;
        private TextBox txtBx2;
        private TextBox txtBx3;
        private TextBox txtBx6;
        private TextBox txtBx5;
        private TextBox txtBx4;
        private TextBox txtBx9;
        private TextBox txtBx8;
        private TextBox txtBx7;
        private Button btnIniciar;
        private Button btnRevisar;
    }
}
