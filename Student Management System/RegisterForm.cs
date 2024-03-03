﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
	public partial class RegisterForm : Form
	{
		StudentClass student = new StudentClass();
		public RegisterForm()
		{
			InitializeComponent();
		}

		private void button_upload_Click(object sender, EventArgs e)
		{
			// browse photo from your computer
			OpenFileDialog opf = new OpenFileDialog();
			opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

			if (opf.ShowDialog()==DialogResult.OK)
			{
				pictureBox_student.Image = Image.FromFile(opf.FileName);
			}
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			// add new student
			string fname = textBox_Fname.Text;
			string lname = textBox_Lname.Text;
			DateTime bdate = dateTimePicker1.Value;
			string phone = textBox_phone.Text;
			string address = textBox_address.Text;
			string gender = radioButton_male.Checked ? "Male" : "Female";

			MemoryStream ms = new MemoryStream();
			pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);
			byte[] img = ms.ToArray();

			// age between 10 and 100

			int born_year = dateTimePicker1.Value.Year;
			int this_year = DateTime.Now.Year;
			if ((this_year-born_year)>100  || (this_year - born_year) < 10)
			{
				MessageBox.Show("The student age must be between 10 and 100", "Invalid Birth date", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (verify())
			{
				try
				{ 
					if (student.insertStudent(fname,lname,bdate,gender,phone,address,img))
					{
						MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);				
					}
				}catch(Exception ex)
					{
						MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
			}
			else
			{
				MessageBox.Show("Empty field","Add Student",MessageBoxButtons.OK,MessageBoxIcon.Warning);	
			}
		}
		bool verify()
		{
			if ((textBox_Fname.Text=="")   || 
				(textBox_Lname.Text=="")   || 
				(textBox_phone.Text=="")   ||
				(textBox_address.Text=="") ||
				(pictureBox_student.Image==null))
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		private void button_clear_Click(object sender, EventArgs e)
		{
			//
		}
	}
}
