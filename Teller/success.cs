using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Florentis;
using System.IO;

namespace Teller
{
    public partial class success : Form
    {
        public success()
        {
            InitializeComponent();
        }
        MySqlCommand cmd;

        private void btnSendEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void success_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("host=localhost;Database=ktb;Uid=root;Pwd=;charset=tis620;");
            string sql = "SELECT * FROM deposit WHERE qr_code='001' ";
            cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtBranch.Text = reader.GetString("branch");
                txtTime.Text = reader.GetString("date");

                if (reader.GetString("deposit_by") == "เงินสด")
                {
                    rdCash.Checked = true;
                    rdTransfer.Checked = false;
                    rdTotalCheq.Checked = false;
                }
                else if (reader.GetString("deposit_by") == "รายการโอน")
                {
                    rdCash.Checked = true;
                    rdTransfer.Checked = false;
                    rdTotalCheq.Checked = false;
                }
                comboBox2.Text = reader.GetString("cheq_num");
                txtAccounntNumber.Text = reader.GetString("account_num");
                txtBranch2.Text = reader.GetString("branch2");
                txtAccountName.Text = reader.GetString("account_name");
                txtAmount.Text = reader.GetString("amount");
                txtAmountText.Text = reader.GetString("amount_text");
                txtPhone.Text = reader.GetString("phone");
                txtTotalAmount.Text = reader.GetString("total_amount");

                var bytes1 = (byte[])reader[11];
                using (MemoryStream ms = new MemoryStream(bytes1))
                {

                    SignCus.Image = Image.FromStream(ms);
                }

                var bytes2 = (byte[])reader[13];
                using (MemoryStream ms = new MemoryStream(bytes2))
                {

                    AuthSign.Image = Image.FromStream(ms);
                }
            }
        }

        private void SignCus_Click(object sender, EventArgs e)
        {

        }
    }
}
