namespace ZooManagemtSystem
{
    partial class StaffManagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_sex = new System.Windows.Forms.TextBox();
            this.tb_pos = new System.Windows.Forms.TextBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_up = new System.Windows.Forms.Button();
            this.bt_sel = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.dtp_birth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_wage = new System.Windows.Forms.TextBox();
            this.tb_department = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 212);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "员工编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "职位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "出生日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "密码";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(323, 13);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(132, 25);
            this.tb_id.TabIndex = 7;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(323, 46);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(132, 25);
            this.tb_name.TabIndex = 8;
            // 
            // tb_sex
            // 
            this.tb_sex.Location = new System.Drawing.Point(323, 122);
            this.tb_sex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_sex.Name = "tb_sex";
            this.tb_sex.Size = new System.Drawing.Size(132, 25);
            this.tb_sex.TabIndex = 9;
            // 
            // tb_pos
            // 
            this.tb_pos.Location = new System.Drawing.Point(323, 79);
            this.tb_pos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_pos.Name = "tb_pos";
            this.tb_pos.Size = new System.Drawing.Size(132, 25);
            this.tb_pos.TabIndex = 10;
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(624, 46);
            this.tb_pwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(132, 25);
            this.tb_pwd.TabIndex = 12;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(201, 175);
            this.bt_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(100, 29);
            this.bt_add.TabIndex = 13;
            this.bt_add.Text = "增加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.Bt_add_Click);
            // 
            // bt_up
            // 
            this.bt_up.Location = new System.Drawing.Point(402, 175);
            this.bt_up.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_up.Name = "bt_up";
            this.bt_up.Size = new System.Drawing.Size(100, 29);
            this.bt_up.TabIndex = 14;
            this.bt_up.Text = "修改";
            this.bt_up.UseVisualStyleBackColor = true;
            this.bt_up.Click += new System.EventHandler(this.Bt_up_Click);
            // 
            // bt_sel
            // 
            this.bt_sel.Location = new System.Drawing.Point(625, 175);
            this.bt_sel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_sel.Name = "bt_sel";
            this.bt_sel.Size = new System.Drawing.Size(100, 29);
            this.bt_sel.TabIndex = 15;
            this.bt_sel.Text = "查询";
            this.bt_sel.UseVisualStyleBackColor = true;
            this.bt_sel.Click += new System.EventHandler(this.Bt_sel_Click);
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(818, 175);
            this.bt_del.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(100, 29);
            this.bt_del.TabIndex = 16;
            this.bt_del.Text = "删除";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.Bt_del_Click);
            // 
            // dtp_birth
            // 
            this.dtp_birth.Location = new System.Drawing.Point(625, 13);
            this.dtp_birth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_birth.Name = "dtp_birth";
            this.dtp_birth.Size = new System.Drawing.Size(131, 25);
            this.dtp_birth.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "工资";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(577, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "部门";
            // 
            // tb_wage
            // 
            this.tb_wage.Location = new System.Drawing.Point(624, 79);
            this.tb_wage.Margin = new System.Windows.Forms.Padding(4);
            this.tb_wage.Name = "tb_wage";
            this.tb_wage.Size = new System.Drawing.Size(132, 25);
            this.tb_wage.TabIndex = 12;
            // 
            // tb_department
            // 
            this.tb_department.Location = new System.Drawing.Point(625, 116);
            this.tb_department.Margin = new System.Windows.Forms.Padding(4);
            this.tb_department.Name = "tb_department";
            this.tb_department.Size = new System.Drawing.Size(132, 25);
            this.tb_department.TabIndex = 12;
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_birth);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.bt_sel);
            this.Controls.Add(this.bt_up);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_department);
            this.Controls.Add(this.tb_wage);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_pos);
            this.Controls.Add(this.tb_sex);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StaffManagement";
            this.Text = "StaffManagement";
            this.Load += new System.EventHandler(this.StaffManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_sex;
        private System.Windows.Forms.TextBox tb_pos;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_up;
        private System.Windows.Forms.Button bt_sel;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.DateTimePicker dtp_birth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_wage;
        private System.Windows.Forms.TextBox tb_department;
    }
}