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
    public partial class MenuReportsFrm : Form
    {
        //Variable Declaration for parent form that gets referenced
        AppInterface_Frm parentForm;


        //Global connection string variable declaration
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Bistro_BusDB.mdf;Integrated Security = True";
        public SqlConnection cnn;

        public MenuReportsFrm(AppInterface_Frm parentForm)
        {
            InitializeComponent();

            //Set parent form
            MdiParent = parentForm;
            this.parentForm = parentForm;
        }

        private void bntItemSearch_Click(object sender, EventArgs e)
        {
            //Set DB connection
            cnn = new SqlConnection(connectionString);
            int menuNum = 0; // Initialize the variable to a default value (0 in this case)

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // First, retrieve the menuNum value
                    string sqlQuery = @"SELECT menuNum FROM Menus WHERE menuItem = @ItemName";
                    using (SqlCommand myCommand = new SqlCommand(sqlQuery, connection))
                    {
                        myCommand.Parameters.AddWithValue("@ItemName", tBItemSearch.Text);

                        using (SqlDataReader dataReader = myCommand.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                // Check if there are any rows returned and read the menuNum value as an integer
                                if (int.TryParse(dataReader["menuNum"].ToString(), out int parsedMenuNum))
                                {
                                    menuNum = parsedMenuNum; // Assign the parsed value to menuNum
                                }
                            }
                        }
                    }

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

                    // Next, use menuNum and the selected date range to retrieve data from the "Bookings" table
                    sqlQuery = @"SELECT * FROM Bookings WHERE menuNum = @ItemNum AND startdate <= @FilterEndDate AND enddate >= @FilterStartDate";

                    using (SqlCommand myCommand = new SqlCommand(sqlQuery, connection))
                    {
                        myCommand.Parameters.AddWithValue("@ItemNum", menuNum);
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
