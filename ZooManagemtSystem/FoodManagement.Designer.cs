namespace ZooManagemtSystem
{
    partial class FoodManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.Fid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fdata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Fbirth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Ftotal = new System.Windows.Forms.TextBox();
            this.Fd_add = new System.Windows.Forms.Button();
            this.Fd_update = new System.Windows.Forms.Button();
            this.Fd_del = new System.Windows.Forms.Button();
            this.Fd_sel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "食物编号";
            // 
            // Fid
            // 
            this.Fid.Location = new System.Drawing.Point(163, 33);
            this.Fid.Name = "Fid";
            this.Fid.Size = new System.Drawing.Size(100, 25);
            this.Fid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "保质期";
            // 
            // Fdata
            // 
            this.Fdata.Location = new System.Drawing.Point(163, 104);
            this.Fdata.Name = "Fdata";
            this.Fdata.Size = new System.Drawing.Size(100, 25);
            this.Fdata.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "食物名称";
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(439, 33);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(100, 25);
            this.Fname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "生产日期";
            // 
            // Fbirth
            // 
            this.Fbirth.Location = new System.Drawing.Point(439, 107);
            this.Fbirth.Name = "Fbirth";
            this.Fbirth.Size = new System.Drawing.Size(100, 25);
            this.Fbirth.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "生产总量";
            // 
            // Ftotal
            // 
            this.Ftotal.Location = new System.Drawing.Point(677, 33);
            this.Ftotal.Name = "Ftotal";
            this.Ftotal.Size = new System.Drawing.Size(100, 25);
            this.Ftotal.TabIndex = 9;
            // 
            // Fd_add
            // 
            this.Fd_add.Location = new System.Drawing.Point(102, 164);
            this.Fd_add.Name = "Fd_add";
            this.Fd_add.Size = new System.Drawing.Size(75, 23);
            this.Fd_add.TabIndex = 10;
            this.Fd_add.Text = "增加";
            this.Fd_add.UseVisualStyleBackColor = true;
            this.Fd_add.Click += new System.EventHandler(this.Fd_add_Click);
            // 
            // Fd_update
            // 
            this.Fd_update.Location = new System.Drawing.Point(261, 164);
            this.Fd_update.Name = "Fd_update";
            this.Fd_update.Size = new System.Drawing.Size(75, 23);
            this.Fd_update.TabIndex = 11;
            this.Fd_update.Text = "修改";
            this.Fd_update.UseVisualStyleBackColor = true;
            // 
            // Fd_del
            // 
            this.Fd_del.Location = new System.Drawing.Point(654, 164);
            this.Fd_del.Name = "Fd_del";
            this.Fd_del.Size = new System.Drawing.Size(75, 23);
            this.Fd_del.TabIndex = 12;
            this.Fd_del.Text = "删除";
            this.Fd_del.UseVisualStyleBackColor = true;
            // 
            // Fd_sel
            // 
            this.Fd_sel.Location = new System.Drawing.Point(474, 164);
            this.Fd_sel.Name = "Fd_sel";
            this.Fd_sel.Size = new System.Drawing.Size(75, 23);
            this.Fd_sel.TabIndex = 13;
            this.Fd_sel.Text = "查询";
            this.Fd_sel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(114, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(615, 192);
            this.dataGridView1.TabIndex = 14;
            // 
            // FoodManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Fd_sel);
            this.Controls.Add(this.Fd_del);
            this.Controls.Add(this.Fd_update);
            this.Controls.Add(this.Fd_add);
            this.Controls.Add(this.Ftotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fbirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fdata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fid);
            this.Controls.Add(this.label1);
            this.Name = "FoodManagement";
            this.Text = "FoodManagement";
            this.Load += new System.EventHandler(this.FoodManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Fbirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Ftotal;
        private System.Windows.Forms.Button Fd_add;
        private System.Windows.Forms.Button Fd_update;
        private System.Windows.Forms.Button Fd_del;
        private System.Windows.Forms.Button Fd_sel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}