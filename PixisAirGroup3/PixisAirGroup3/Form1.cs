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

namespace PixisAirProject
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pixisAirDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.pixisAirDataSet.customers);

        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            String connectionString = "Data Source=V2StudentPOC;Initial Catalog=PixisAir;" +
                        "Persist Security Info=True;User ID=student;Password=ichooseGateway";
            String SQL = "SELECT CFNAME, CLNAME FROM customers";
            try
            {
                connection = new SqlConnection(connectionString);
                adapter = new SqlDataAdapter(SQL, connection);
                DataSet data = new DataSet();
                connection.Open();
                adapter.Fill(data);
                displayListBox.Items.Add("First Name       Last Name");
                displayListBox.Items.Add("----------------------------------------------");
                foreach (DataRow dataRow in data.Tables[0].Rows)
                    displayListBox.Items.Add(dataRow[0] + ", " + dataRow[1]);
                connection.Close();
            }
            catch (Exception ex)
            {
                displayListBox.Items.Add(ex.Message);
            }
        }
    }
}
