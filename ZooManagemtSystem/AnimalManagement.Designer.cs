namespace ZooManagemtSystem
{
    partial class AnimalManagement
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
            this.bt_del = new System.Windows.Forms.Button();
            this.bt_sel = new System.Windows.Forms.Button();
            this.bt_up = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_sex = new System.Windows.Forms.TextBox();
            this.tb_kind = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(820, 156);
            this.bt_del.Margin = new System.Windows.Forms.Padding(4);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(100, 29);
            this.bt_del.TabIndex = 21;
            this.bt_del.Text = "删除";
            this.bt_del.UseVisualStyleBackColor = true;
            // 
            // bt_sel
            // 
            this.bt_sel.Location = new System.Drawing.Point(627, 156);
            this.bt_sel.Margin = new System.Windows.Forms.Padding(4);
            this.bt_sel.Name = "bt_sel";
            this.bt_sel.Size = new System.Drawing.Size(100, 29);
            this.bt_sel.TabIndex = 20;
            this.bt_sel.Text = "查询";
            this.bt_sel.UseVisualStyleBackColor = true;
            // 
            // bt_up
            // 
            this.bt_up.Location = new System.Drawing.Point(404, 156);
            this.bt_up.Margin = new System.Windows.Forms.Padding(4);
            this.bt_up.Name = "bt_up";
            this.bt_up.Size = new System.Drawing.Size(100, 29);
            this.bt_up.TabIndex = 19;
            this.bt_up.Text = "修改";
            this.bt_up.UseVisualStyleBackColor = true;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(203, 156);
            this.bt_add.Margin = new System.Windows.Forms.Padding(4);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(100, 29);
            this.bt_add.TabIndex = 18;
            this.bt_add.Text = "增加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 212);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 335);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "名字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "种类";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "出生日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "状态";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(249, 35);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(132, 25);
            this.tb_id.TabIndex = 28;
            // 
            // tb_sex
            // 
            this.tb_sex.Location = new System.Drawing.Point(479, 70);
            this.tb_sex.Margin = new System.Windows.Forms.Padding(4);
            this.tb_sex.Name = "tb_sex";
            this.tb_sex.Size = new System.Drawing.Size(132, 25);
            this.tb_sex.TabIndex = 29;
            // 
            // tb_kind
            // 
            this.tb_kind.Location = new System.Drawing.Point(479, 35);
            this.tb_kind.Margin = new System.Windows.Forms.Padding(4);
            this.tb_kind.Name = "tb_kind";
            this.tb_kind.Size = new System.Drawing.Size(132, 25);
            this.tb_kind.TabIndex = 30;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(249, 70);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(132, 25);
            this.tb_name.TabIndex = 31;
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(761, 70);
            this.tb_status.Margin = new System.Windows.Forms.Padding(4);
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(132, 25);
            this.tb_status.TabIndex = 32;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(761, 35);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 25);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // AnimalManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_status);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_kind);
            this.Controls.Add(this.tb_sex);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.bt_sel);
            this.Controls.Add(this.bt_up);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnimalManagement";
            this.Text = "AnimalManagement";
            this.Load += new System.EventHandler(this.AnimalManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.Button bt_sel;
        private System.Windows.Forms.Button bt_up;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_sex;
        private System.Windows.Forms.TextBox tb_kind;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}