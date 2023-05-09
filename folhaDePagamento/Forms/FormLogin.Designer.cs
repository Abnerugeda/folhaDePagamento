namespace folhaDePagamento.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            boxUsuario = new TextBox();
            boxSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // boxUsuario
            // 
            boxUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            boxUsuario.Location = new Point(162, 241);
            boxUsuario.Name = "boxUsuario";
            boxUsuario.Size = new Size(233, 32);
            boxUsuario.TabIndex = 0;
            // 
            // boxSenha
            // 
            boxSenha.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            boxSenha.Location = new Point(162, 302);
            boxSenha.Name = "boxSenha";
            boxSenha.Size = new Size(233, 32);
            boxSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(211, 169);
            label1.Name = "label1";
            label1.Size = new Size(128, 47);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(162, 223);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(162, 284);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            // 
            // btnLogin
            // 
            btnLogin.IconChar = FontAwesome.Sharp.IconChar.N;
            btnLogin.IconColor = Color.Black;
            btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogin.IconSize = 1;
            btnLogin.Location = new Point(162, 369);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(233, 49);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(102, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(344, 140);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(552, 483);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(boxSenha);
            Controls.Add(boxUsuario);
            MaximizeBox = false;
            MaximumSize = new Size(568, 522);
            MinimizeBox = false;
            MinimumSize = new Size(568, 522);
            Name = "FormLogin";
            ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox boxUsuario;
        private TextBox boxSenha;
        private Label label1;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnLogin;
        private PictureBox pictureBox1;
    }
}