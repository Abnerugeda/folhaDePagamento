namespace folhaDePagamento.Forms
{
    partial class FormSuporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuporte));
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(34, 33, 74);
            linkLabel1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(224, 337);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(353, 37);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "devabnerugeda@gmail.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(34, 33, 74);
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(286, 384);
            label2.Name = "label2";
            label2.Size = new Size(216, 37);
            label2.TabIndex = 4;
            label2.Text = "(16) 99792-6503";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(34, 33, 74);
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(297, 300);
            label1.Name = "label1";
            label1.Size = new Size(193, 37);
            label1.TabIndex = 3;
            label1.Text = "ABNER UGEDA";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(234, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 140);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormSuporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(811, 513);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            HelpButton = true;
            Name = "FormSuporte";
            Text = "FormSuporte";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}