namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.button3 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Seller = new System.Windows.Forms.TabPage();
            this.CommandDetail = new System.Windows.Forms.TabPage();
            this.StoreKeeper = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button12 = new System.Windows.Forms.Button();
            this.Recap = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.Box = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.Corniere = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.Base = new System.Windows.Forms.TabPage();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StoreKeeper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Recap.SuspendLayout();
            this.Box.SuspendLayout();
            this.Corniere.SuspendLayout();
            this.Base.SuspendLayout();
            this.Main.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(974, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.Firebrick;
            this.textBox11.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox11.Location = new System.Drawing.Point(992, 12);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(184, 51);
            this.textBox11.TabIndex = 15;
            this.textBox11.Text = "KitBox";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(975, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 51);
            this.button4.TabIndex = 26;
            this.button4.Text = "Afficher récapitulatif";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Maroon;
            this.textBox7.Location = new System.Drawing.Point(974, 248);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(238, 36);
            this.textBox7.TabIndex = 34;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged_1);
            // 
            // Seller
            // 
            this.Seller.Location = new System.Drawing.Point(4, 14);
            this.Seller.Name = "Seller";
            this.Seller.Padding = new System.Windows.Forms.Padding(3);
            this.Seller.Size = new System.Drawing.Size(928, 506);
            this.Seller.TabIndex = 7;
            this.Seller.Text = "Seller";
            this.Seller.UseVisualStyleBackColor = true;
            // 
            // CommandDetail
            // 
            this.CommandDetail.Location = new System.Drawing.Point(4, 14);
            this.CommandDetail.Name = "CommandDetail";
            this.CommandDetail.Padding = new System.Windows.Forms.Padding(3);
            this.CommandDetail.Size = new System.Drawing.Size(928, 506);
            this.CommandDetail.TabIndex = 6;
            this.CommandDetail.Text = "CommandDetail";
            this.CommandDetail.UseVisualStyleBackColor = true;
            this.CommandDetail.Click += new System.EventHandler(this.tabPage7_Click);
            // 
            // StoreKeeper
            // 
            this.StoreKeeper.Controls.Add(this.button12);
            this.StoreKeeper.Controls.Add(this.dataGridView1);
            this.StoreKeeper.Location = new System.Drawing.Point(4, 16);
            this.StoreKeeper.Name = "StoreKeeper";
            this.StoreKeeper.Padding = new System.Windows.Forms.Padding(3);
            this.StoreKeeper.Size = new System.Drawing.Size(928, 504);
            this.StoreKeeper.TabIndex = 5;
            this.StoreKeeper.Text = "StoreKeeper";
            this.StoreKeeper.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(901, 437);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(6, 449);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(901, 43);
            this.button12.TabIndex = 3;
            this.button12.Text = "Load Table";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Recap
            // 
            this.Recap.Controls.Add(this.textBox9);
            this.Recap.Controls.Add(this.button5);
            this.Recap.Location = new System.Drawing.Point(4, 16);
            this.Recap.Name = "Recap";
            this.Recap.Padding = new System.Windows.Forms.Padding(3);
            this.Recap.Size = new System.Drawing.Size(928, 504);
            this.Recap.TabIndex = 4;
            this.Recap.Text = "Recap";
            this.Recap.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(6, 453);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(916, 39);
            this.button5.TabIndex = 36;
            this.button5.Text = "Fermer récapitulatif";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.LightGray;
            this.textBox9.Location = new System.Drawing.Point(6, 16);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(916, 431);
            this.textBox9.TabIndex = 0;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // Box
            // 
            this.Box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Box.Controls.Add(this.button7);
            this.Box.Controls.Add(this.checkBox1);
            this.Box.Controls.Add(this.textBox1);
            this.Box.Controls.Add(this.textBox6);
            this.Box.Controls.Add(this.textBox5);
            this.Box.Controls.Add(this.textBox4);
            this.Box.Controls.Add(this.comboBox1);
            this.Box.Controls.Add(this.comboBox3);
            this.Box.Controls.Add(this.comboBox5);
            this.Box.Controls.Add(this.button1);
            this.Box.Location = new System.Drawing.Point(4, 14);
            this.Box.Name = "Box";
            this.Box.Padding = new System.Windows.Forms.Padding(3);
            this.Box.Size = new System.Drawing.Size(928, 506);
            this.Box.TabIndex = 2;
            this.Box.Text = "Box";
            this.Box.Click += new System.EventHandler(this.Box_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(30, 303);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(250, 40);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Couleur des portes :";
            this.textBox4.Visible = false;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(914, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter un casier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.ItemHeight = 25;
            this.comboBox5.Items.AddRange(new object[] {
            "Blanc",
            "Brun",
            "Galvanisé",
            "Noir",
            "Verre"});
            this.comboBox5.Location = new System.Drawing.Point(376, 175);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(253, 33);
            this.comboBox5.TabIndex = 31;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ItemHeight = 25;
            this.comboBox3.Items.AddRange(new object[] {
            "Blanc",
            "Brun",
            "Galvanisé",
            "Noir",
            "Verre"});
            this.comboBox3.Location = new System.Drawing.Point(376, 303);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(250, 33);
            this.comboBox3.TabIndex = 29;
            this.comboBox3.Visible = false;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(30, 175);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(250, 40);
            this.textBox5.TabIndex = 32;
            this.textBox5.Text = "Couleur des panneaux :";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.textBox6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox6.Location = new System.Drawing.Point(30, 6);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(185, 36);
            this.textBox6.TabIndex = 33;
            this.textBox6.Text = "Casier 1";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.ItemHeight = 25;
            this.comboBox1.Items.AddRange(new object[] {
            "0"});
            this.comboBox1.Location = new System.Drawing.Point(376, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 33);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(30, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(250, 40);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Hauteur du casier :";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(240, 250);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(184, 24);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "Présence de portes";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(8, 441);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(914, 51);
            this.button7.TabIndex = 37;
            this.button7.Text = "Terminer la commande";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Corniere
            // 
            this.Corniere.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Corniere.Controls.Add(this.comboBox7);
            this.Corniere.Controls.Add(this.textBox8);
            this.Corniere.Controls.Add(this.button2);
            this.Corniere.Location = new System.Drawing.Point(4, 14);
            this.Corniere.Name = "Corniere";
            this.Corniere.Padding = new System.Windows.Forms.Padding(3);
            this.Corniere.Size = new System.Drawing.Size(928, 506);
            this.Corniere.TabIndex = 3;
            this.Corniere.Text = "Cornière";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(919, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(327, 163);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(250, 40);
            this.textBox8.TabIndex = 4;
            this.textBox8.Text = "Couleur cornières :";
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox7.ItemHeight = 25;
            this.comboBox7.Items.AddRange(new object[] {
            "0"});
            this.comboBox7.Location = new System.Drawing.Point(327, 232);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(250, 33);
            this.comboBox7.TabIndex = 28;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // Base
            // 
            this.Base.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Base.Controls.Add(this.button6);
            this.Base.Controls.Add(this.textBox2);
            this.Base.Controls.Add(this.textBox3);
            this.Base.Controls.Add(this.comboBox2);
            this.Base.Controls.Add(this.comboBox4);
            this.Base.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Base.Location = new System.Drawing.Point(4, 14);
            this.Base.Name = "Base";
            this.Base.Padding = new System.Windows.Forms.Padding(3);
            this.Base.Size = new System.Drawing.Size(928, 506);
            this.Base.TabIndex = 1;
            this.Base.Text = "Base";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.ItemHeight = 25;
            this.comboBox4.Items.AddRange(new object[] {
            "0"});
            this.comboBox4.Location = new System.Drawing.Point(334, 300);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(250, 33);
            this.comboBox4.TabIndex = 30;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.AllowDrop = true;
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 25;
            this.comboBox2.Items.AddRange(new object[] {
            "0"});
            this.comboBox2.Location = new System.Drawing.Point(334, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(250, 33);
            this.comboBox2.TabIndex = 28;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(334, 239);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(250, 40);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Selectionner largeur :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(334, 98);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(250, 40);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Sélectionner longueur :";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(6, 445);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(916, 37);
            this.button6.TabIndex = 31;
            this.button6.Text = "Valider";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Main.Controls.Add(this.button10);
            this.Main.Controls.Add(this.button9);
            this.Main.Controls.Add(this.button8);
            this.Main.Cursor = System.Windows.Forms.Cursors.Default;
            this.Main.Location = new System.Drawing.Point(4, 14);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(928, 506);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(189, 83);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(549, 69);
            this.button8.TabIndex = 37;
            this.button8.Text = "Customer";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(342, 272);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(238, 51);
            this.button9.TabIndex = 38;
            this.button9.Text = "Store Keeper";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(342, 186);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(238, 51);
            this.button10.TabIndex = 39;
            this.button10.Text = "Seller";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.Main);
            this.tabControl1.Controls.Add(this.Base);
            this.tabControl1.Controls.Add(this.Corniere);
            this.tabControl1.Controls.Add(this.Box);
            this.tabControl1.Controls.Add(this.Recap);
            this.tabControl1.Controls.Add(this.StoreKeeper);
            this.tabControl1.Controls.Add(this.CommandDetail);
            this.tabControl1.Controls.Add(this.Seller);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.ItemSize = new System.Drawing.Size(45, 10);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 524);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1225, 556);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "View User";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.StoreKeeper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Recap.ResumeLayout(false);
            this.Recap.PerformLayout();
            this.Box.ResumeLayout(false);
            this.Box.PerformLayout();
            this.Corniere.ResumeLayout(false);
            this.Corniere.PerformLayout();
            this.Base.ResumeLayout(false);
            this.Base.PerformLayout();
            this.Main.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TabPage Seller;
        private System.Windows.Forms.TabPage CommandDetail;
        private System.Windows.Forms.TabPage StoreKeeper;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Recap;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage Box;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Corniere;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage Base;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

