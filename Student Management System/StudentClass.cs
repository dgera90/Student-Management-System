using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Management_System
{
	internal class StudentClass
	{
		DBconnect connect = new DBconnect();

		public bool insertStudent(string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`StdFristName`, `StdLastName`, `Birthdate`, `Gender`, `Phone`, `Address`, `Photo`) VALUES (@fn,@ln,@bd,@gd,@ph,@adr,@img)", connect.getconnection);

			// @fn,@ln,@bd,@gd,@ph,@adr,@img

			command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
			command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
			command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
			command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
			command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
			command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

			connect.openConnect();

			if (command.ExecuteNonQuery()==1)
			{
				connect.closeConnect();
				return true;
			}
			else
			{
				connect.closeConnect();
				return false;
			}
		}
	}
}
