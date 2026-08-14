using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class BillsScreen : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Basti\Documents\Pro-Natur Bimoarkt GmbH.mdf;Integrated Security = True; Connect Timeout = 30");
        private int lastSelectedBillsKey = 0;
        public BillsScreen()
        {
            InitializeComponent();
            ShowBills();
        }

        private void ShowBills()
        {
            sqlConnection.Open();
            string query = "select * from Bills";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            DVGBills.DataSource = dataSet.Tables[0];

            sqlConnection.Close();
        }

        private void AllFieldsClear()
        {
            textBoxInvoiceNo.Clear();
            textBoxAmount.Clear();
            textBoxBirthday.Clear();
            textBoxCity.Clear();
            textBoxFirstname.Clear();
            textBoxName.Clear();
            textBoxPurchasedOn.Clear();
            
        }

        private void ExcuteQuery(string query)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnBillsSave_Click(object sender, EventArgs e)
        {
            string billsName = textBoxName.Text;
            string billsFirst = textBoxFirstname.Text;
            string billsBirthday = textBoxBirthday.Text;
            string billsCity = textBoxCity.Text;
            string billsPurchased = textBoxPurchasedOn.Text;
            string billsAmount = textBoxAmount.Text;

            string query = $"insert into Bills values('{billsName}','{billsFirst}','{billsBirthday}','{billsCity}','{billsPurchased}','{billsAmount}')";
            ExcuteQuery(query);

            AllFieldsClear();
            ShowBills();
        }

        private void btnBillsEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedBillsKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus.");
                return;
            }
            string billsName = textBoxName.Text;
            string billsFirst = textBoxFirstname.Text;
            string billsBirthday = textBoxBirthday.Text;
            string billsCity = textBoxCity.Text;
            string billsPurchased = textBoxPurchasedOn.Text;
            string billsAmount = textBoxAmount.Text;

            string query = $"update Bills set Name= '{billsName}',Firstname='{billsFirst}',Birthday='{billsBirthday}',City='{billsCity}',[Purchased on]='{billsPurchased}',Amount='{billsAmount}' Where [Invoice Number] ={lastSelectedBillsKey};";
            ExcuteQuery(query);

            AllFieldsClear();
            ShowBills();
        }

        private void btnBillsClear_Click(object sender, EventArgs e)
        {
            AllFieldsClear();
        }

        private void btnBillsDelete_Click(object sender, EventArgs e)
        {
            if (lastSelectedBillsKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus.");
                return;
            }
            string query = $"delete from Bills where [Invoice Number] = {lastSelectedBillsKey};";
            ExcuteQuery(query);


            AllFieldsClear();
            ShowBills();
        }

        private void DVGBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxInvoiceNo.Text = DVGBills.SelectedRows[0].Cells[0].Value.ToString();
            textBoxName.Text = DVGBills.SelectedRows[0].Cells[1].Value.ToString();
            textBoxFirstname.Text = DVGBills.SelectedRows[0].Cells[2].Value.ToString();
            textBoxBirthday.Text = DVGBills.SelectedRows[0].Cells[3].Value.ToString();
            textBoxCity.Text = DVGBills.SelectedRows[0].Cells[4].Value.ToString();
            textBoxPurchasedOn.Text = DVGBills.SelectedRows[0].Cells[5].Value.ToString();
            textBoxAmount.Text = DVGBills.SelectedRows[0].Cells[6].Value.ToString();

            lastSelectedBillsKey = (int)DVGBills.SelectedRows[0].Cells[0].Value;
        }
    }
}
