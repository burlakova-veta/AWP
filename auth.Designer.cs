namespace arm_net
{
    partial class auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear_log = new System.Windows.Forms.PictureBox();
            this.clear = new System.Windows.Forms.PictureBox();
            this.pict_yes = new System.Windows.Forms.PictureBox();
            this.pict_no = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clear_log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_yes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_no)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(80, 19);
            this.login.MaxLength = 50;
            this.login.MinimumSize = new System.Drawing.Size(144, 22);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(175, 24);
            this.login.TabIndex = 2;
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(80, 67);
            this.password.MaxLength = 50;
            this.password.MinimumSize = new System.Drawing.Size(144, 22);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(175, 24);
            this.password.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.clear_log);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.pict_yes);
            this.panel1.Controls.Add(this.pict_no);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(28, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 107);
            this.panel1.TabIndex = 4;
            // 
            // clear_log
            // 
            this.clear_log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_log.Image = global::arm_net.Properties.Resources.очистка;
            this.clear_log.Location = new System.Drawing.Point(255, 19);
            this.clear_log.Name = "clear_log";
            this.clear_log.Size = new System.Drawing.Size(23, 23);
            this.clear_log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clear_log.TabIndex = 7;
            this.clear_log.TabStop = false;
            this.clear_log.Click += new System.EventHandler(this.clear_log_Click);
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.Image = global::arm_net.Properties.Resources.очистка;
            this.clear.Location = new System.Drawing.Point(255, 67);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(23, 23);
            this.clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clear.TabIndex = 6;
            this.clear.TabStop = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // pict_yes
            // 
            this.pict_yes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pict_yes.Image = global::arm_net.Properties.Resources.показать;
            this.pict_yes.Location = new System.Drawing.Point(281, 66);
            this.pict_yes.Name = "pict_yes";
            this.pict_yes.Size = new System.Drawing.Size(30, 25);
            this.pict_yes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_yes.TabIndex = 5;
            this.pict_yes.TabStop = false;
            this.pict_yes.Click += new System.EventHandler(this.pict_yes_Click);
            // 
            // pict_no
            // 
            this.pict_no.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pict_no.Image = global::arm_net.Properties.Resources.скрыть;
            this.pict_no.Location = new System.Drawing.Point(281, 66);
            this.pict_no.MaximumSize = new System.Drawing.Size(30, 25);
            this.pict_no.MinimumSize = new System.Drawing.Size(30, 25);
            this.pict_no.Name = "pict_no";
            this.pict_no.Size = new System.Drawing.Size(30, 25);
            this.pict_no.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_no.TabIndex = 5;
            this.pict_no.TabStop = false;
            this.pict_no.Click += new System.EventHandler(this.pict_no_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Location = new System.Drawing.Point(143, 171);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(109, 41);
            this.save.TabIndex = 4;
            this.save.Text = "Войти";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 233);
            this.Controls.Add(this.save);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(470, 280);
            this.MinimumSize = new System.Drawing.Size(410, 280);
            this.Name = "auth";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clear_log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_yes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_no)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.PictureBox pict_no;
        private System.Windows.Forms.PictureBox pict_yes;
        private System.Windows.Forms.PictureBox clear;
        private System.Windows.Forms.PictureBox clear_log;
    }
}

