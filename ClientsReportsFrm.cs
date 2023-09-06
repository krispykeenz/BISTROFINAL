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
    public partial class ClientsReportsFrm : Form
    {
        //Variable Declaration for parent form that gets referenced
        AppInterface_Frm parentForm;

        //Global connection string variable declaration
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Bistro_BusDB.mdf;Integrated Security = True";
        public SqlConnection cnn;
        public ClientsReportsFrm(AppInterface_Frm parentForm)
        {
            InitializeComponent();

            //Set parent form
            MdiParent = parentForm;
            this.parentForm = parentForm;
        }

        private void bntClientSearch_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            try
            {
                //Set the string to the clients name
                String sqlQuery = @"SELECT clientName,clientAdress,clientEmail,clientContactNum FROM Clients WHERE clientNum =@ClientNum";
                //Open connection
                cnn.Open();

                //Set SqlDataAdapter, DataSet and SqlCommand
                SqlDataAdapter myAdapter = new SqlDataAdapter();
                DataSet myDataSet = new DataSet();
                String sql_query = sqlQuery;
                SqlCommand myCommand = new SqlCommand(sql_query, cnn);
                myCommand.Parameters.AddWithValue("@ClientNum", tBClientSearch.Text);

                //Fill the DataSet
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(myDataSet, "Bookings");

                //Add Data to DataGridView
                dgvSearchBookings.DataSource = myDataSet;
                dgvSearchBookings.DataMember = "Bookings";

                //Show all events
                SqlDataReader datareader;
                datareader = myCommand.ExecuteReader();

                //Close connection
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error Connecting to Database", MessageBoxButtons.OK);
                // Log the exception for debugging purposes
            }
        }
    }
}
