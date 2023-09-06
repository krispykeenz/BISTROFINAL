/*CMPG223 Group 14 Project Bistro_Bus
Janco Pretorius (40951499)
Keenan Burriss (37831909)
Pieter Swart (44529996)
Marco Van Den Heever (38302187)
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_Bistro_Bus
{
    public partial class BookingsReportsFrm : Form
    {
        //Variable Declaration for parent form that gets referenced
        AppInterface_Frm parentForm;

        //Global connection string variable declaration
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Bistro_BusDB.mdf;Integrated Security = True";
        public SqlConnection cnn;

        public BookingsReportsFrm(AppInterface_Frm parentForm)
        {
            InitializeComponent();

            //Set parent form
            MdiParent = parentForm;
            this.parentForm = parentForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Set DB connection
            cnn = new SqlConnection(connectionString);


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Determine the date range based on the selected radio button
                    DateTime currentDate = DateTime.Now.Date; // Get the current date without the time component
                    DateTime filterStartDate;
                    DateTime filterEndDate;

                    if (rBPast.Checked)
                    {
                        // Filter for past entries where enddate is before the current date
                        filterStartDate = currentDate;
                        filterEndDate = currentDate;
                    }
                    else if (rBWeek.Checked)
                    {
                        // Filter for entries in the next 7 days
                        filterStartDate = currentDate;
                        filterEndDate = currentDate.AddDays(7);
                    }
                    else if (rBMonth.Checked)
                    {
                        // Filter for entries in the next 30 days
                        filterStartDate = currentDate;
                        filterEndDate = currentDate.AddDays(30);
                    }
                    else
                    {
                        // Default to show all entries if no radio button is selected
                        filterStartDate = DateTime.Parse("1753-01-01"); // Minimum valid date for SQL Server DATE type
                        filterEndDate = DateTime.MaxValue.Date; // Date value with the highest valid date
                    }

                    // Next, retrieve bookings based on clientNum and the selected date range
                    string sqlQuery = @"SELECT * FROM Bookings WHERE clientNum = @ClientNum AND startdate <= @FilterEndDate AND enddate >= @FilterStartDate";
                    using (SqlCommand myCommand = new SqlCommand(sqlQuery, connection))
                    {
                        myCommand.Parameters.AddWithValue("@ClientNum", tBClientSearch.Text);
                        myCommand.Parameters.AddWithValue("@FilterStartDate", filterStartDate);
                        myCommand.Parameters.AddWithValue("@FilterEndDate", filterEndDate);

                        using (SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand))
                        {
                            using (DataSet myDataSet = new DataSet())
                            {
                                myAdapter.Fill(myDataSet, "Bookings");
                                dgvSearchBookings.DataSource = myDataSet;
                                dgvSearchBookings.DataMember = "Bookings";
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error Connecting to Database", MessageBoxButtons.OK);
                // Log the exception for debugging purposes
            }
        }
    }
}
