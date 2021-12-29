namespace ZooManagemtSystem
{
    partial class FeedManagement
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
            this.Aid = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Fid = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Wid = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Aid
            // 
            this.Aid.AutoSize = true;
            this.Aid.Location = new System.Drawing.Point(60, 33);
            this.Aid.Name = "Aid";
            this.Aid.Size = new System.Drawing.Size(67, 15);
            this.Aid.TabIndex = 0;
            this.Aid.Text = "动物编号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            // 
            // Fid
            // 
            this.Fid.AutoSize = true;
            this.Fid.Location = new System.Drawing.Point(60, 106);
            this.Fid.Name = "Fid";
            this.Fid.Size = new System.Drawing.Size(67, 15);
            this.Fid.TabIndex = 2;
            this.Fid.Text = "食物编号";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 3;
            // 
            // Wid
            // 
            this.Wid.AutoSize = true;
            this.Wid.Location = new System.Drawing.Point(344, 33);
            this.Wid.Name = "Wid";
            this.Wid.Size = new System.Drawing.Size(67, 15);
            this.Wid.TabIndex = 4;
            this.Wid.Text = "职工编号";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(420, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 5;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(344, 106);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(67, 15);
            this.Time.TabIndex = 6;
            this.Time.Text = "投食时间";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(420, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 25);
            this.textBox4.TabIndex = 7;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(574, 33);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(52, 15);
            this.Total.TabIndex = 8;
            this.Total.Text = "投食量";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(672, 30);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 25);
            this.textBox5.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Fe_sel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(431, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(577, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 24);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(568, 177);
            this.dataGridView1.TabIndex = 14;
            // 
            // FeedManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Wid);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Fid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Aid);
            this.Name = "FeedManagement";
            this.Text = "FeedManagement";
            this.Load += new System.EventHandler(this.FeedManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Aid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Fid;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Wid;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}