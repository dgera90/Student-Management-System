namespace Student_Management_System
{
	partial class RegisterForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_Fname = new System.Windows.Forms.TextBox();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
			this.textBox_Lname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.radioButton_male = new System.Windows.Forms.RadioButton();
			this.radioButton_female = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox_address = new System.Windows.Forms.TextBox();
			this.pictureBox_student = new System.Windows.Forms.PictureBox();
			this.button_upload = new System.Windows.Forms.Button();
			this.textBox_phone = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button_clear = new System.Windows.Forms.Button();
			this.button_add = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label1.Location = new System.Drawing.Point(8, 369);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "First Name :";
			// 
			// textBox_Fname
			// 
			this.textBox_Fname.Location = new System.Drawing.Point(111, 365);
			this.textBox_Fname.Name = "textBox_Fname";
			this.textBox_Fname.Size = new System.Drawing.Size(126, 27);
			this.textBox_Fname.TabIndex = 2;
			// 
			// guna2DataGridView1
			// 
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.guna2DataGridView1.ColumnHeadersHeight = 4;
			this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
			this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.Location = new System.Drawing.Point(12, 67);
			this.guna2DataGridView1.Name = "guna2DataGridView1";
			this.guna2DataGridView1.RowHeadersVisible = false;
			this.guna2DataGridView1.Size = new System.Drawing.Size(910, 275);
			this.guna2DataGridView1.TabIndex = 3;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
			this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// textBox_Lname
			// 
			this.textBox_Lname.Location = new System.Drawing.Point(347, 365);
			this.textBox_Lname.Name = "textBox_Lname";
			this.textBox_Lname.Size = new System.Drawing.Size(143, 27);
			this.textBox_Lname.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label2.Location = new System.Drawing.Point(243, 369);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "Last Name :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label3.Location = new System.Drawing.Point(8, 421);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 19);
			this.label3.TabIndex = 6;
			this.label3.Text = "Date of birth :";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(120, 421);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(293, 27);
			this.dateTimePicker1.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label4.Location = new System.Drawing.Point(457, 425);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 19);
			this.label4.TabIndex = 8;
			this.label4.Text = "Gender :";
			// 
			// radioButton_male
			// 
			this.radioButton_male.AutoSize = true;
			this.radioButton_male.Checked = true;
			this.radioButton_male.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.radioButton_male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.radioButton_male.Location = new System.Drawing.Point(566, 423);
			this.radioButton_male.Name = "radioButton_male";
			this.radioButton_male.Size = new System.Drawing.Size(66, 23);
			this.radioButton_male.TabIndex = 9;
			this.radioButton_male.TabStop = true;
			this.radioButton_male.Text = "Male";
			this.radioButton_male.UseVisualStyleBackColor = true;
			// 
			// radioButton_female
			// 
			this.radioButton_female.AutoSize = true;
			this.radioButton_female.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.radioButton_female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.radioButton_female.Location = new System.Drawing.Point(661, 423);
			this.radioButton_female.Name = "radioButton_female";
			this.radioButton_female.Size = new System.Drawing.Size(86, 23);
			this.radioButton_female.TabIndex = 10;
			this.radioButton_female.TabStop = true;
			this.radioButton_female.Text = "Female";
			this.radioButton_female.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label5.Location = new System.Drawing.Point(8, 487);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 19);
			this.label5.TabIndex = 11;
			this.label5.Text = "Address :";
			// 
			// textBox_address
			// 
			this.textBox_address.Location = new System.Drawing.Point(120, 487);
			this.textBox_address.Name = "textBox_address";
			this.textBox_address.Size = new System.Drawing.Size(627, 27);
			this.textBox_address.TabIndex = 12;
			// 
			// pictureBox_student
			// 
			this.pictureBox_student.BackColor = System.Drawing.Color.LightGray;
			this.pictureBox_student.Location = new System.Drawing.Point(809, 382);
			this.pictureBox_student.Name = "pictureBox_student";
			this.pictureBox_student.Size = new System.Drawing.Size(87, 105);
			this.pictureBox_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_student.TabIndex = 13;
			this.pictureBox_student.TabStop = false;
			// 
			// button_upload
			// 
			this.button_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button_upload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button_upload.ForeColor = System.Drawing.Color.White;
			this.button_upload.Location = new System.Drawing.Point(807, 506);
			this.button_upload.Name = "button_upload";
			this.button_upload.Size = new System.Drawing.Size(88, 35);
			this.button_upload.TabIndex = 14;
			this.button_upload.Text = " Upload";
			this.button_upload.UseVisualStyleBackColor = false;
			this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
			// 
			// textBox_phone
			// 
			this.textBox_phone.Location = new System.Drawing.Point(596, 365);
			this.textBox_phone.Name = "textBox_phone";
			this.textBox_phone.Size = new System.Drawing.Size(151, 27);
			this.textBox_phone.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label6.Location = new System.Drawing.Point(513, 369);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 19);
			this.label6.TabIndex = 15;
			this.label6.Text = "Phone :";
			// 
			// button_clear
			// 
			this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.button_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button_clear.ForeColor = System.Drawing.Color.White;
			this.button_clear.Location = new System.Drawing.Point(693, 566);
			this.button_clear.Name = "button_clear";
			this.button_clear.Size = new System.Drawing.Size(88, 35);
			this.button_clear.TabIndex = 17;
			this.button_clear.Text = "Clear";
			this.button_clear.UseVisualStyleBackColor = false;
			this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
			// 
			// button_add
			// 
			this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button_add.ForeColor = System.Drawing.Color.White;
			this.button_add.Location = new System.Drawing.Point(807, 566);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(88, 35);
			this.button_add.TabIndex = 18;
			this.button_add.Text = "Add";
			this.button_add.UseVisualStyleBackColor = false;
			this.button_add.Click += new System.EventHandler(this.button_add_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.panel1.Controls.Add(this.label7);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(934, 61);
			this.panel1.TabIndex = 19;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(378, 19);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(129, 25);
			this.label7.TabIndex = 0;
			this.label7.Text = "Registration";
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(934, 613);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button_add);
			this.Controls.Add(this.button_clear);
			this.Controls.Add(this.textBox_phone);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button_upload);
			this.Controls.Add(this.pictureBox_student);
			this.Controls.Add(this.textBox_address);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.radioButton_female);
			this.Controls.Add(this.radioButton_male);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox_Lname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.guna2DataGridView1);
			this.Controls.Add(this.textBox_Fname);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "RegisterForm";
			this.Text = "RegisterForm";
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_Fname;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
		private System.Windows.Forms.TextBox textBox_Lname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radioButton_male;
		private System.Windows.Forms.RadioButton radioButton_female;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_address;
		private System.Windows.Forms.PictureBox pictureBox_student;
		private System.Windows.Forms.Button button_upload;
		private System.Windows.Forms.TextBox textBox_phone;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button_clear;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label7;
	}
}