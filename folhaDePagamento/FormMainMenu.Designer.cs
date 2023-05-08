namespace folhaDePagamento
{
    partial class FormMainMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            panelMenu = new Panel();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            panel1 = new Panel();
            lblHome = new Label();
            iconHome = new FontAwesome.Sharp.IconPictureBox();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            lblData = new Label();
            lblHorario = new Label();
            timerNow = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconHome).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 60);
            panelMenu.Controls.Add(iconButton5);
            panelMenu.Controls.Add(iconButton4);
            panelMenu.Controls.Add(iconButton3);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 627);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panel1_Paint;
            // 
            // iconButton5
            // 
            iconButton5.Dock = DockStyle.Top;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.ForeColor = SystemColors.ButtonFace;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            iconButton5.IconColor = Color.Gainsboro;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 32;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(0, 380);
            iconButton5.Name = "iconButton5";
            iconButton5.Padding = new Padding(10, 0, 20, 0);
            iconButton5.Size = new Size(220, 60);
            iconButton5.TabIndex = 5;
            iconButton5.Text = "Suporte";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            iconButton5.Click += iconButton5_Click;
            // 
            // iconButton4
            // 
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = SystemColors.ButtonFace;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Gears;
            iconButton4.IconColor = Color.Gainsboro;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 32;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 320);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(10, 0, 20, 0);
            iconButton4.Size = new Size(220, 60);
            iconButton4.TabIndex = 4;
            iconButton4.Text = "Configurações";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton3
            // 
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.ForeColor = SystemColors.ButtonFace;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconButton3.IconColor = Color.Gainsboro;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 32;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 260);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(10, 0, 20, 0);
            iconButton3.Size = new Size(220, 60);
            iconButton3.TabIndex = 3;
            iconButton3.Text = "Funcionários";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = SystemColors.ButtonFace;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Pager;
            iconButton2.IconColor = Color.Gainsboro;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 200);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 20, 0);
            iconButton2.Size = new Size(220, 60);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "Folha";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = SystemColors.ButtonFace;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cube;
            iconButton1.IconColor = Color.Gainsboro;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 140);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(220, 60);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "DashBoard";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImage = (Image)resources.GetObject("panelLogo.BackgroundImage");
            panelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            panelLogo.Click += iconPictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 25, 62);
            panel1.Controls.Add(lblHome);
            panel1.Controls.Add(iconHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 75);
            panel1.TabIndex = 1;
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.ForeColor = Color.Gainsboro;
            lblHome.Location = new Point(55, 29);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(40, 15);
            lblHome.TabIndex = 1;
            lblHome.Text = "Home";
            lblHome.Click += lblHome_Click;
            // 
            // iconHome
            // 
            iconHome.BackColor = Color.FromArgb(26, 25, 62);
            iconHome.ForeColor = Color.MediumPurple;
            iconHome.IconChar = FontAwesome.Sharp.IconChar.House;
            iconHome.IconColor = Color.MediumPurple;
            iconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconHome.Location = new Point(20, 21);
            iconHome.Name = "iconHome";
            iconHome.Size = new Size(32, 32);
            iconHome.TabIndex = 0;
            iconHome.TabStop = false;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Controls.Add(lblData);
            panelDesktop.Controls.Add(lblHorario);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 75);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(827, 552);
            panelDesktop.TabIndex = 2;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(250, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 140);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblData
            // 
            lblData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblData.ForeColor = SystemColors.ButtonShadow;
            lblData.Location = new Point(184, 377);
            lblData.Name = "lblData";
            lblData.Size = new Size(130, 54);
            lblData.TabIndex = 0;
            lblData.Text = "label1";
            // 
            // lblHorario
            // 
            lblHorario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            lblHorario.ForeColor = Color.Gainsboro;
            lblHorario.Location = new Point(320, 305);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(172, 72);
            lblHorario.TabIndex = 0;
            lblHorario.Text = "label1";
            // 
            // timerNow
            // 
            timerNow.Enabled = true;
            timerNow.Tick += timerNow_Tick;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 627);
            Controls.Add(panelDesktop);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            MaximizeBox = false;
            MaximumSize = new Size(1063, 666);
            MinimizeBox = false;
            MinimumSize = new Size(1063, 666);
            Name = "FormMainMenu";
            ShowIcon = false;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconHome).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panelLogo;
        private Panel panel1;
        private Label lblHome;
        private FontAwesome.Sharp.IconPictureBox iconHome;
        private Panel panelDesktop;
        private Label lblData;
        private Label lblHorario;
        private System.Windows.Forms.Timer timerNow;
        private PictureBox pictureBox1;
    }
}