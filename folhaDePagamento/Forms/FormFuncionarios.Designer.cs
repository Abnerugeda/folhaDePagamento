namespace folhaDePagamento.Forms
{
    partial class FormFuncionarios
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
            this.listFuncionarios = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnRemover = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // listFuncionarios
            // 
            this.listFuncionarios.BackColor = System.Drawing.Color.White;
            this.listFuncionarios.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listFuncionarios.ForeColor = System.Drawing.Color.Black;
            this.listFuncionarios.Location = new System.Drawing.Point(48, 78);
            this.listFuncionarios.Name = "listFuncionarios";
            this.listFuncionarios.Size = new System.Drawing.Size(682, 333);
            this.listFuncionarios.TabIndex = 0;
            this.listFuncionarios.UseCompatibleStateImageBehavior = false;
            this.listFuncionarios.SelectedIndexChanged += new System.EventHandler(this.listFuncionarios_SelectedIndexChanged);
            this.listFuncionarios.DoubleClick += new System.EventHandler(this.listFuncionarios_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(227, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funcionários";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 30;
            this.btnAdd.Location = new System.Drawing.Point(70, 417);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.btnRemover.FlatAppearance.BorderSize = 3;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnRemover.IconColor = System.Drawing.Color.White;
            this.btnRemover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemover.IconSize = 25;
            this.btnRemover.Location = new System.Drawing.Point(539, 417);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(168, 50);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(811, 513);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listFuncionarios);
            this.Name = "FormFuncionarios";
            this.Text = "FormFuncionarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listFuncionarios;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnRemover;
    }
}