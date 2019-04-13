namespace WindowsFormsApp7
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.comboBoxPassword = new System.Windows.Forms.ComboBox();
            this.buttonPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPassword
            // 
            this.comboBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPassword.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxPassword.FormattingEnabled = true;
            this.comboBoxPassword.ItemHeight = 16;
            this.comboBoxPassword.Location = new System.Drawing.Point(198, 263);
            this.comboBoxPassword.Name = "comboBoxPassword";
            this.comboBoxPassword.Size = new System.Drawing.Size(173, 16);
            this.comboBoxPassword.TabIndex = 1;
            this.comboBoxPassword.SelectedIndexChanged += new System.EventHandler(this.comboBoxPassword_SelectedIndexChanged);
            // 
            // buttonPassword
            // 
            this.buttonPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPassword.BackColor = System.Drawing.Color.Black;
            this.buttonPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPassword.BackgroundImage")));
            this.buttonPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPassword.Location = new System.Drawing.Point(327, 426);
            this.buttonPassword.MaximumSize = new System.Drawing.Size(135, 94);
            this.buttonPassword.Name = "buttonPassword";
            this.buttonPassword.Size = new System.Drawing.Size(135, 94);
            this.buttonPassword.TabIndex = 2;
            this.buttonPassword.UseVisualStyleBackColor = false;
            this.buttonPassword.Click += new System.EventHandler(this.buttonPassword_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.buttonPassword);
            this.Controls.Add(this.comboBoxPassword);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Login";
            this.Text = "Login ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPassword;
        private System.Windows.Forms.Button buttonPassword;
    }
}

