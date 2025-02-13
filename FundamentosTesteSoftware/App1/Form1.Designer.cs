namespace App1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSubmit = new Button();
            btnSenha = new TextBox();
            btnEmail = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.Font = new Font("Segoe UI", 11.8F, FontStyle.Bold);
            btnSubmit.Location = new Point(246, 260);
            btnSubmit.Margin = new Padding(3, 2, 3, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(438, 28);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Entrar";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button1_Click;
            // 
            // btnSenha
            // 
            btnSenha.Anchor = AnchorStyles.None;
            btnSenha.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSenha.Location = new Point(246, 218);
            btnSenha.Margin = new Padding(3, 2, 3, 2);
            btnSenha.MaxLength = 8;
            btnSenha.Name = "btnSenha";
            btnSenha.PasswordChar = '*';
            btnSenha.PlaceholderText = "********";
            btnSenha.Size = new Size(438, 32);
            btnSenha.TabIndex = 2;
            btnSenha.TextAlign = HorizontalAlignment.Center;
            btnSenha.UseSystemPasswordChar = true;
            btnSenha.TextChanged += btnSenha_TextChanged;
            // 
            // btnEmail
            // 
            btnEmail.Anchor = AnchorStyles.None;
            btnEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmail.Location = new Point(246, 177);
            btnEmail.Margin = new Padding(3, 2, 3, 2);
            btnEmail.MaxLength = 0;
            btnEmail.Name = "btnEmail";
            btnEmail.PlaceholderText = "meu@email";
            btnEmail.Size = new Size(438, 32);
            btnEmail.TabIndex = 1;
            btnEmail.TextAlign = HorizontalAlignment.Center;
            btnEmail.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(427, 376);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 3;
            label1.Text = "Versão 1.0.0";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Design_sem_nome_4;
            pictureBox1.Location = new Point(396, 40);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(930, 398);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(btnEmail);
            Controls.Add(btnSenha);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "SIG - Sistema Integrado de Gerenciamento";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private TextBox btnSenha;
        private TextBox btnEmail;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
