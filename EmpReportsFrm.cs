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
    public partial class EmpReportsFrm : Form
    {
        //Variable Declaration for parent form that gets referenced
        AppInterface_Frm parentForm;

        //Global connection string variable declaration
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Bistro_BusDB.mdf;Integrated Security = True";
        public SqlConnection cnn;
        public EmpReportsFrm(AppInterface_Frm parentForm)
        {
            InitializeComponent();

            //Set parent form
            MdiParent = parentForm;
            this.parentForm = parentForm;
        }

        private void EmpReportsFrm_Load(object sender, EventArgs e)
        {

        }

        private void bntEmpSearch_Click(object sender, EventArgs e)
        {
            //Set DB connection
            cnn = new SqlConnection(connectionString);
            int EmpNum = 0; // Initialize the variable to a default value (0 in this case)


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // First, retrieve the empNum value
                    string sqlQuery = @"SELECT empNum FROM Employees WHERE empName = @EmpName";
                    using (SqlCommand myCommand = new SqlCommand(sqlQuery, connection))
                    {
                        myCommand.Parameters.AddWithValue("@EmpName", tBEmpSearch.Text); // Use .Text to get the value from the TextBox

                        using (SqlDataReader dataReader = myCommand.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                // Check if there are any rows returned and read the empNum value as an integer
                                if (int.TryParse(dataReader["empNum"].ToString(), out int parsedEmpNum))
                                {
                                    EmpNum = parsedEmpNum; // Assign the parsed value to EmpNum
                                }
                            }
                        }
                    }

                    // Next, use EmpNum to retrieve data from the "Bookings" table
                    sqlQuery = @"SELECT * FROM Bookings WHERE empNum = @EmpNum"; 
                    using (SqlCommand myCommand = new SqlCommand(sqlQuery, connection))
                    {
                        myCommand.Parameters.AddWithValue("@EmpNum", EmpNum); 

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
