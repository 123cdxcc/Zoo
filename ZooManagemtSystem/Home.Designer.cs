namespace ZooManagemtSystem
{
    partial class Home
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
            this.Staff = new System.Windows.Forms.Button();
            this.Animal = new System.Windows.Forms.Button();
            this.Food = new System.Windows.Forms.Button();
            this.Feed = new System.Windows.Forms.Button();
            this.Purchase = new System.Windows.Forms.Button();
            this.Care = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Staff
            // 
            this.Staff.Location = new System.Drawing.Point(265, 99);
            this.Staff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(159, 55);
            this.Staff.TabIndex = 0;
            this.Staff.Text = "职工管理";
            this.Staff.UseVisualStyleBackColor = true;
            this.Staff.Click += new System.EventHandler(this.Staff_Click);
            // 
            // Animal
            // 
            this.Animal.Location = new System.Drawing.Point(516, 99);
            this.Animal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Animal.Name = "Animal";
            this.Animal.Size = new System.Drawing.Size(159, 55);
            this.Animal.TabIndex = 1;
            this.Animal.Text = "动物管理";
            this.Animal.UseVisualStyleBackColor = true;
            this.Animal.Click += new System.EventHandler(this.Animal_Click);
            // 
            // Food
            // 
            this.Food.Location = new System.Drawing.Point(265, 215);
            this.Food.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(159, 55);
            this.Food.TabIndex = 2;
            this.Food.Text = "食物管理";
            this.Food.UseVisualStyleBackColor = true;
            this.Food.Click += new System.EventHandler(this.Food_Click);
            // 
            // Feed
            // 
            this.Feed.Location = new System.Drawing.Point(516, 215);
            this.Feed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Feed.Name = "Feed";
            this.Feed.Size = new System.Drawing.Size(159, 55);
            this.Feed.TabIndex = 3;
            this.Feed.Text = "投食记录";
            this.Feed.UseVisualStyleBackColor = true;
            this.Feed.Click += new System.EventHandler(this.Feed_Click);
            // 
            // Purchase
            // 
            this.Purchase.Location = new System.Drawing.Point(265, 321);
            this.Purchase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Purchase.Name = "Purchase";
            this.Purchase.Size = new System.Drawing.Size(159, 55);
            this.Purchase.TabIndex = 4;
            this.Purchase.Text = "采购记录";
            this.Purchase.UseVisualStyleBackColor = true;
            this.Purchase.Click += new System.EventHandler(this.Purchase_Click);
            // 
            // Care
            // 
            this.Care.Location = new System.Drawing.Point(516, 321);
            this.Care.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Care.Name = "Care";
            this.Care.Size = new System.Drawing.Size(159, 55);
            this.Care.TabIndex = 5;
            this.Care.Text = "照料记录";
            this.Care.UseVisualStyleBackColor = true;
            this.Care.Click += new System.EventHandler(this.Care_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.Care);
            this.Controls.Add(this.Purchase);
            this.Controls.Add(this.Feed);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Animal);
            this.Controls.Add(this.Staff);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Staff;
        private System.Windows.Forms.Button Animal;
        private System.Windows.Forms.Button Food;
        private System.Windows.Forms.Button Feed;
        private System.Windows.Forms.Button Purchase;
        private System.Windows.Forms.Button Care;
    }
}