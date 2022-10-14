
namespace edevinvenmgmt
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.label1 = new System.Windows.Forms.Label();
            this.MaterialEntryButton = new System.Windows.Forms.Button();
            this.MaterialDispatchButton = new System.Windows.Forms.Button();
            this.LocateItemButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(283, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose what to do :";
            // 
            // MaterialEntryButton
            // 
            this.MaterialEntryButton.BackColor = System.Drawing.Color.Transparent;
            this.MaterialEntryButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaterialEntryButton.Location = new System.Drawing.Point(317, 281);
            this.MaterialEntryButton.Name = "MaterialEntryButton";
            this.MaterialEntryButton.Size = new System.Drawing.Size(213, 38);
            this.MaterialEntryButton.TabIndex = 2;
            this.MaterialEntryButton.Text = "Material Entry";
            this.MaterialEntryButton.UseVisualStyleBackColor = false;
            this.MaterialEntryButton.Click += new System.EventHandler(this.MaterialEntryButton_Click);
            // 
            // MaterialDispatchButton
            // 
            this.MaterialDispatchButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaterialDispatchButton.Location = new System.Drawing.Point(317, 325);
            this.MaterialDispatchButton.Name = "MaterialDispatchButton";
            this.MaterialDispatchButton.Size = new System.Drawing.Size(213, 38);
            this.MaterialDispatchButton.TabIndex = 3;
            this.MaterialDispatchButton.Text = "Material Dispatch";
            this.MaterialDispatchButton.UseVisualStyleBackColor = true;
            this.MaterialDispatchButton.Click += new System.EventHandler(this.MaterialDispatchButton_Click);
            // 
            // LocateItemButton
            // 
            this.LocateItemButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocateItemButton.Location = new System.Drawing.Point(317, 369);
            this.LocateItemButton.Name = "LocateItemButton";
            this.LocateItemButton.Size = new System.Drawing.Size(213, 38);
            this.LocateItemButton.TabIndex = 4;
            this.LocateItemButton.Text = "Locate Item";
            this.LocateItemButton.UseVisualStyleBackColor = true;
            this.LocateItemButton.Click += new System.EventHandler(this.LocateItemButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 80);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(501, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(315, 84);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(72, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "EDEV Inventory Management System";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 510);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LocateItemButton);
            this.Controls.Add(this.MaterialDispatchButton);
            this.Controls.Add(this.MaterialEntryButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MaterialEntryButton;
        private System.Windows.Forms.Button MaterialDispatchButton;
        private System.Windows.Forms.Button LocateItemButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

