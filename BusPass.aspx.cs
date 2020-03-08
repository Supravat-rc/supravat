using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace BusPassApplication
{
    public partial class BusPass : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-4FAB0LO;Initial Catalog=EMPLOYEE;Integrated Security=True");
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                BusPassClass busPassClass = new BusPassClass();
                busPassClass.StudentID = Convert.ToInt32(txtStudentID.Text);
                busPassClass.StudentName = txtStudentName.Text;
                busPassClass.Source = txtSource.Text;
                busPassClass.Destination = txtDestination.Text;
                busPassClass.Address = txtAddress.Text;
                busPassClass.ContactNo = double.Parse(txtContactNo.Text);
                connection.Open();
                command = new SqlCommand("insert into BussPass values(  @StudentID ,@StudentName ,@Source , @Destination ,  @Address, @ContactNo )", connection);
                command.Parameters.AddWithValue("@StudentID", txtStudentID);
                command.Parameters.AddWithValue("@StudentName", txtStudentName);
                command.Parameters.AddWithValue("@Source", txtSource);
                command.Parameters.AddWithValue("@Destination", txtDestination);
                command.Parameters.AddWithValue("@Address", txtAddress);
                command.Parameters.AddWithValue("@ContactNo", txtContactNo);

            command.Connection = connection;
                int check = command.ExecuteNonQuery();
                if (check == 1)
                {
                    Response.Write("Data inserted successfully");
                }
                else
                {
                    Response.Write("Failure");
                }
                connection.Close();
            //}
            //catch(Exception exception)
            //{

            //   Response.Write (exception.Message);
            //}


        }
    }
}