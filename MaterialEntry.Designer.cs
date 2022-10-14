
namespace edevinvenmgmt
{
    partial class MaterialEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialEntry));
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.OfficeRadio = new System.Windows.Forms.RadioButton();
            this.ProjectRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MaterialEntryButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchProjectButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ProCodeTb = new System.Windows.Forms.TextBox();
            this.MatCodeTb = new System.Windows.Forms.TextBox();
            this.MatNameTb = new System.Windows.Forms.TextBox();
            this.MatTypeTb = new System.Windows.Forms.TextBox();
            this.MatQtyTb = new System.Windows.Forms.TextBox();
            this.MatLocationTb = new System.Windows.Forms.TextBox();
            this.ProNameTb = new System.Windows.Forms.TextBox();
            this.ItemListTb = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HomeButton = new System.Windows.Forms.Button();
            this.CreateProjectButton = new System.Windows.Forms.Button();
            this.NewEntryButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(534, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material Entry";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(302, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(644, 38);
            this.Title.TabIndex = 1;
            this.Title.Text = "EDEV Inventory Management System";
            // 
            // OfficeRadio
            // 
            this.OfficeRadio.AutoSize = true;
            this.OfficeRadio.BackColor = System.Drawing.Color.Transparent;
            this.OfficeRadio.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OfficeRadio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OfficeRadio.Location = new System.Drawing.Point(90, 206);
            this.OfficeRadio.Name = "OfficeRadio";
            this.OfficeRadio.Size = new System.Drawing.Size(251, 41);
            this.OfficeRadio.TabIndex = 2;
            this.OfficeRadio.Text = "Office Material";
            this.OfficeRadio.UseVisualStyleBackColor = false;
            this.OfficeRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ProjectRadio
            // 
            this.ProjectRadio.AutoSize = true;
            this.ProjectRadio.BackColor = System.Drawing.Color.Transparent;
            this.ProjectRadio.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectRadio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProjectRadio.Location = new System.Drawing.Point(672, 206);
            this.ProjectRadio.Name = "ProjectRadio";
            this.ProjectRadio.Size = new System.Drawing.Size(267, 41);
            this.ProjectRadio.TabIndex = 3;
            this.ProjectRadio.Text = "Project Material";
            this.ProjectRadio.UseVisualStyleBackColor = false;
            this.ProjectRadio.CheckedChanged += new System.EventHandler(this.ProjectRadio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(90, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Material Code";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(90, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Material Type";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(90, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Material Name";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(90, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantity";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(90, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 37);
            this.label6.TabIndex = 8;
            this.label6.Text = "Location";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(672, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 37);
            this.label7.TabIndex = 9;
            this.label7.Text = "Project Code";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(672, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 37);
            this.label8.TabIndex = 10;
            this.label8.Text = "Project Name";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(672, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 37);
            this.label9.TabIndex = 11;
            this.label9.Text = "Date And Time";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(686, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 74);
            this.label10.TabIndex = 12;
            this.label10.Text = "Items List \r\nAnd Qty";
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // MaterialEntryButton
            // 
            this.MaterialEntryButton.BackColor = System.Drawing.Color.Transparent;
            this.MaterialEntryButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaterialEntryButton.ForeColor = System.Drawing.Color.Black;
            this.MaterialEntryButton.Location = new System.Drawing.Point(108, 637);
            this.MaterialEntryButton.Name = "MaterialEntryButton";
            this.MaterialEntryButton.Size = new System.Drawing.Size(213, 38);
            this.MaterialEntryButton.TabIndex = 14;
            this.MaterialEntryButton.Text = "Save Details";
            this.MaterialEntryButton.UseVisualStyleBackColor = false;
            this.MaterialEntryButton.Visible = false;
            this.MaterialEntryButton.Click += new System.EventHandler(this.MaterialEntryButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(473, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchProjectButton
            // 
            this.SearchProjectButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SearchProjectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchProjectButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchProjectButton.ForeColor = System.Drawing.Color.Black;
            this.SearchProjectButton.Location = new System.Drawing.Point(1176, 286);
            this.SearchProjectButton.Name = "SearchProjectButton";
            this.SearchProjectButton.Size = new System.Drawing.Size(100, 85);
            this.SearchProjectButton.TabIndex = 16;
            this.SearchProjectButton.Text = "Search by code";
            this.SearchProjectButton.UseVisualStyleBackColor = false;
            this.SearchProjectButton.Visible = false;
            this.SearchProjectButton.Click += new System.EventHandler(this.SearchProjectButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(90, 562);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(233, 37);
            this.label12.TabIndex = 16;
            this.label12.Text = "Date And Time";
            this.label12.Visible = false;
            // 
            // ProCodeTb
            // 
            this.ProCodeTb.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProCodeTb.Location = new System.Drawing.Point(909, 286);
            this.ProCodeTb.Name = "ProCodeTb";
            this.ProCodeTb.Size = new System.Drawing.Size(250, 39);
            this.ProCodeTb.TabIndex = 23;
            this.ProCodeTb.Visible = false;
            // 
            // MatCodeTb
            // 
            this.MatCodeTb.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MatCodeTb.Location = new System.Drawing.Point(331, 271);
            this.MatCodeTb.Name = "MatCodeTb";
            this.MatCodeTb.Size = new System.Drawing.Size(250, 39);
            this.MatCodeTb.TabIndex = 17;
            this.MatCodeTb.Visible = false;
            // 
            // MatNameTb
            // 
            this.MatNameTb.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MatNameTb.Location = new System.Drawing.Point(331, 334);
            this.MatNameTb.Name = "MatNameTb";
            this.MatNameTb.Size = new System.Drawing.Size(250, 39);
            this.MatNameTb.TabIndex = 19;
            this.MatNameTb.Visible = false;
            // 
            // MatTypeTb
            // 
            this.MatTypeTb.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MatTypeTb.Location = new System.Drawing.Point(331, 396);
            this.MatTypeTb.Name = "MatTypeTb";
            this.MatTypeTb.Size = new System.Drawing.Size(250, 39);
            this.MatTypeTb.TabIndex = 21;
            this.MatTypeTb.Visible = false;
            // 
            // MatQtyTb
            // 
            this.MatQtyTb.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MatQtyTb.Location = new System.Drawing.Point(331, 446);
            this.MatQtyTb.Name = "MatQtyTb";
            this.MatQtyTb.Size = new System.Drawing.Size(250, 39);
            this.MatQtyTb.TabIndex = 22;
            this.MatQtyTb.Visible = false;
            // 
            // MatLocationTb
            // 
            this.MatLocationTb.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MatLocationTb.Location = new System.Drawing.Point(331, 504);
            this.MatLocationTb.Name = "MatLocationTb";
            this.MatLocationTb.Size = new System.Drawing.Size(250, 39);
            this.MatLocationTb.TabIndex = 23;
            this.MatLocationTb.Visible = false;
            // 
            // ProNameTb
            // 
            this.ProNameTb.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProNameTb.Location = new System.Drawing.Point(909, 341);
            this.ProNameTb.Name = "ProNameTb";
            this.ProNameTb.Size = new System.Drawing.Size(250, 39);
            this.ProNameTb.TabIndex = 24;
            this.ProNameTb.Visible = false;
            // 
            // ItemListTb
            // 
            this.ItemListTb.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemListTb.Location = new System.Drawing.Point(909, 453);
            this.ItemListTb.Multiline = true;
            this.ItemListTb.Name = "ItemListTb";
            this.ItemListTb.PlaceholderText = "Name_Qty, ...";
            this.ItemListTb.Size = new System.Drawing.Size(250, 137);
            this.ItemListTb.TabIndex = 26;
            this.ItemListTb.Visible = false;
            this.ItemListTb.TextChanged += new System.EventHandler(this.ItemListTb_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(331, 564);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 39);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.Value = new System.DateTime(2022, 7, 5, 20, 22, 24, 0);
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Location = new System.Drawing.Point(909, 403);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 39);
            this.dateTimePicker2.TabIndex = 29;
            this.dateTimePicker2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(712, 963);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(376, 186);
            this.dataGridView1.TabIndex = 30;
            // 
            // HomeButton
            // 
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.Location = new System.Drawing.Point(613, 740);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(108, 38);
            this.HomeButton.TabIndex = 31;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // CreateProjectButton
            // 
            this.CreateProjectButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateProjectButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateProjectButton.ForeColor = System.Drawing.Color.Black;
            this.CreateProjectButton.Location = new System.Drawing.Point(1176, 484);
            this.CreateProjectButton.Name = "CreateProjectButton";
            this.CreateProjectButton.Size = new System.Drawing.Size(100, 92);
            this.CreateProjectButton.TabIndex = 32;
            this.CreateProjectButton.Text = "Create Project";
            this.CreateProjectButton.UseVisualStyleBackColor = false;
            this.CreateProjectButton.Visible = false;
            this.CreateProjectButton.Click += new System.EventHandler(this.CreateProjectButton_Click);
            // 
            // NewEntryButton
            // 
            this.NewEntryButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewEntryButton.Location = new System.Drawing.Point(111, 702);
            this.NewEntryButton.Name = "NewEntryButton";
            this.NewEntryButton.Size = new System.Drawing.Size(213, 38);
            this.NewEntryButton.TabIndex = 33;
            this.NewEntryButton.Text = "New Material Entry";
            this.NewEntryButton.UseVisualStyleBackColor = true;
            this.NewEntryButton.Visible = false;
            this.NewEntryButton.Click += new System.EventHandler(this.NewEntryButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditButton.ForeColor = System.Drawing.Color.Black;
            this.EditButton.Location = new System.Drawing.Point(1176, 389);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(100, 87);
            this.EditButton.TabIndex = 34;
            this.EditButton.Text = "Edit By Code";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Visible = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1107, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 76);
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // MaterialEntry
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1288, 796);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.NewEntryButton);
            this.Controls.Add(this.CreateProjectButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ItemListTb);
            this.Controls.Add(this.ProNameTb);
            this.Controls.Add(this.MatLocationTb);
            this.Controls.Add(this.MatQtyTb);
            this.Controls.Add(this.MatTypeTb);
            this.Controls.Add(this.MatNameTb);
            this.Controls.Add(this.MatCodeTb);
            this.Controls.Add(this.ProCodeTb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SearchProjectButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MaterialEntryButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjectRadio);
            this.Controls.Add(this.OfficeRadio);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaterialEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaterialEntry";
            this.Load += new System.EventHandler(this.MaterialEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.RadioButton OfficeRadio;
        private System.Windows.Forms.RadioButton ProjectRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button MaterialEntryButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SearchProjectButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ProCodeTb;
        private System.Windows.Forms.TextBox MatCodeTb;
        private System.Windows.Forms.TextBox MatNameTb;
        private System.Windows.Forms.TextBox MatTypeTb;
        private System.Windows.Forms.TextBox MatQtyTb;
        private System.Windows.Forms.TextBox MatLocationTb;
        private System.Windows.Forms.TextBox ProNameTb;
        private System.Windows.Forms.TextBox ItemListTb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button CreateProjectButton;
        private System.Windows.Forms.Button NewEntryButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}