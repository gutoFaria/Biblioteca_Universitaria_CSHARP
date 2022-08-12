namespace LibraryManagement
{
    partial class FormLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCatastrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureBoxCapes = new System.Windows.Forms.PictureBox();
            this.pictureBoxCnpq = new System.Windows.Forms.PictureBox();
            this.pictureBoxFapesp = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCnpq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFapesp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LibraryManagement.Properties.Resources.icons8_login_64;
            this.pictureBox4.Location = new System.Drawing.Point(117, 35);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(117, 257);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(167, 19);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "Senha";
            this.txtSenha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSenha_MouseClick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::LibraryManagement.Properties.Resources.icons8_usuário_30;
            this.pictureBox5.Location = new System.Drawing.Point(66, 174);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::LibraryManagement.Properties.Resources.icons8_desbloquear_2_50;
            this.pictureBox6.Location = new System.Drawing.Point(66, 246);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(45, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Teal;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(80, 312);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(204, 38);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCatastrar
            // 
            this.btnCatastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCatastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCatastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatastrar.ForeColor = System.Drawing.Color.Teal;
            this.btnCatastrar.Location = new System.Drawing.Point(80, 367);
            this.btnCatastrar.Name = "btnCatastrar";
            this.btnCatastrar.Size = new System.Drawing.Size(204, 38);
            this.btnCatastrar.TabIndex = 6;
            this.btnCatastrar.Text = "Cadastrar";
            this.btnCatastrar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(118, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 1);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(117, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 1);
            this.panel4.TabIndex = 8;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(312, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(21, 21);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // pictureBoxCapes
            // 
            this.pictureBoxCapes.Image = global::LibraryManagement.Properties.Resources.capes;
            this.pictureBoxCapes.Location = new System.Drawing.Point(43, 426);
            this.pictureBoxCapes.Name = "pictureBoxCapes";
            this.pictureBoxCapes.Size = new System.Drawing.Size(68, 50);
            this.pictureBoxCapes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCapes.TabIndex = 10;
            this.pictureBoxCapes.TabStop = false;
            this.pictureBoxCapes.Click += new System.EventHandler(this.pictureBoxCapes_Click);
            // 
            // pictureBoxCnpq
            // 
            this.pictureBoxCnpq.Image = global::LibraryManagement.Properties.Resources.cnpq;
            this.pictureBoxCnpq.Location = new System.Drawing.Point(140, 426);
            this.pictureBoxCnpq.Name = "pictureBoxCnpq";
            this.pictureBoxCnpq.Size = new System.Drawing.Size(68, 50);
            this.pictureBoxCnpq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCnpq.TabIndex = 11;
            this.pictureBoxCnpq.TabStop = false;
            this.pictureBoxCnpq.Click += new System.EventHandler(this.pictureBoxCnpq_Click);
            // 
            // pictureBoxFapesp
            // 
            this.pictureBoxFapesp.Image = global::LibraryManagement.Properties.Resources.fapesp;
            this.pictureBoxFapesp.Location = new System.Drawing.Point(234, 426);
            this.pictureBoxFapesp.Name = "pictureBoxFapesp";
            this.pictureBoxFapesp.Size = new System.Drawing.Size(68, 50);
            this.pictureBoxFapesp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFapesp.TabIndex = 12;
            this.pictureBoxFapesp.TabStop = false;
            this.pictureBoxFapesp.Click += new System.EventHandler(this.pictureBoxFapesp_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(117, 185);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(167, 19);
            this.txtUsuario.TabIndex = 13;
            this.txtUsuario.Text = "Usuário";
            this.txtUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUsuario_MouseClick);
            // 
            // FormLogin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(334, 488);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pictureBoxFapesp);
            this.Controls.Add(this.pictureBoxCnpq);
            this.Controls.Add(this.pictureBoxCapes);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCatastrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCnpq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFapesp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCatastrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBoxCapes;
        private System.Windows.Forms.PictureBox pictureBoxCnpq;
        private System.Windows.Forms.PictureBox pictureBoxFapesp;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}

