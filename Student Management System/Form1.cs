﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			customizeDesign();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void customizeDesign()
		{
			panel_stdsubmenu.Visible = false;
			panel_courseSubmenu.Visible = false;
			panel_scoreSubmenu.Visible = false;
		}

		private void hideSubmenu()
		{
			if (panel_stdsubmenu.Visible==true)
			{
				panel_stdsubmenu.Visible = false;
			}
			if (panel_courseSubmenu.Visible==true)
			{
				panel_courseSubmenu.Visible = false;
			}
			if (panel_scoreSubmenu.Visible == true)
			{
				panel_scoreSubmenu.Visible = false;
			}
		}
		private void showSubmenu(Panel submenu)
		{
			if (submenu.Visible == false)
			{
				hideSubmenu();
				submenu.Visible = true;
			}
			else
			{
				submenu.Visible = false;
			}
		}

		private void button_std_Click(object sender, EventArgs e)
		{
			showSubmenu(panel_stdsubmenu);
		}
		#region StdSubmenu
		private void button_registration_Click(object sender, EventArgs e)
		{
			//...
			//..Your code
			//...
			hideSubmenu();
		}

		private void button_manageStd_Click(object sender, EventArgs e)
		{
			//...
			//..Your code
			//...
			hideSubmenu();
		}

		private void button_status_Click(object sender, EventArgs e)
		{
			//...
			//..Your code
			//...
			hideSubmenu();
		}

		private void button_stdPrint_Click(object sender, EventArgs e)
		{
			//...
			//..Your code
			//...
			hideSubmenu();
		}
		#endregion StdSubmenu
		private void button_course_Click(object sender, EventArgs e)
		{
			showSubmenu(panel_courseSubmenu);
		}

		#region CourseSubmenu

		private void button_newCourse_Click(object sender, EventArgs e)
		{
			//...
			//..Your code
			//...
			hideSubmenu();
		}

		private void button_manageCourse_Click(object sender, EventArgs e)
		{
			//...
			//..Your code
			//...
			hideSubmenu();
		}

		private void button_coursePrint_Click(object sender, EventArgs e)
		{
			//...
			//..Your code
			//...
			hideSubmenu();
		}
		#endregion CourseSubmenu
		private void button_score_Click(object sender, EventArgs e)
		{
			showSubmenu(panel_scoreSubmenu);
		}

		#region ScoreSubmenu

		private void button_newScore_Click(object sender, EventArgs e)
		{
			//...
			//..Your code
			//...
			hideSubmenu();
		}

		private void button_manageScore_Click(object sender, EventArgs e)
		{
			//...
			//..Your code
			//...
			hideSubmenu();
		}

		private void button_scorePrint_Click(object sender, EventArgs e)
		{
			//...
			//..Your code
			//...
			hideSubmenu();
		}
		#endregion ScoreSubmenu

	}
}
