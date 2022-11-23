using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;

namespace PixisAirProject
{
    public partial class Form2 : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataset;
        public Form2()
        {
            InitializeComponent();
        }

        private void cUSTOMERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTOMERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            String sql;

            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu");
                sql = "SELECT * FROM CUSTOMER";
                adapter = new iDB2DataAdapter(sql, conn);

                dataset = new DataSet();
                adapter.Fill(dataset);

                displayListBox.Items.Clear();
                foreach (DataRow pRow in dataset.Tables[0].Rows)
                    displayListBox.Items.Add(pRow[0] + " " + pRow[1] + " " + pRow[2] + " " + pRow[3]
                        + " " + pRow[4] + " " + pRow[5] + " " + pRow[6] + " " + pRow[7] + " " + pRow[8]
                        + " " + pRow[9] + " " + pRow[10] + " " + pRow[11] + " " + pRow[12] + " " + pRow[13]
                        + " " + pRow[14]);
                conn.Close();

            }
            catch (Exception ex)
            {
                displayListBox.Items.Add(ex.Message);
            }
        }
    }
}
