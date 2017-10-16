using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teller
{
    public partial class success_withdraw : Form
    {
        public success_withdraw()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void success_withdraw_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("host=localhost;Database=ktb;Uid=root;Pwd=;charset=tis620;");
            MySqlCommand cmd = new MySqlCommand();
            string sql = "SELECT * FROM withdrawal WHERE qr_code='001' ";
            cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtBranch.Text = reader.GetString("branch");
                txtTime.Text = reader.GetString("date");

                if (reader.GetString("withdraw_by") == "เงินสด")
                {
                    rdCash.Checked = true;
                    rdTransfer.Checked = false;
                    rdTotalCheq.Checked = false;
                }
                else if (reader.GetString("withdraw_by") == "รายการโอน")
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

                txtNameWith.Text = reader.GetString("name_receiver");
                txtTypeCard.Text = reader.GetString("type_card");
                txtIdNum.Text = reader.GetString("id_num");
                txtDateExpire.Text = reader.GetString("expire");
                txtCreateBy.Text = reader.GetString("create_by");
                txtTotalAmount.Text = reader.GetString("total_amount");

                var bytes1 = (byte[])reader[16];
                using (MemoryStream ms = new MemoryStream(bytes1))
                {

                    AccountOwnerSignature.Image = Image.FromStream(ms);
                }

                var bytes2 = (byte[])reader[17];
                using (MemoryStream ms = new MemoryStream(bytes2))
                {

                    ReceiverSign.Image = Image.FromStream(ms);
                }

                var bytes3 = (byte[])reader[19];
                using (MemoryStream ms = new MemoryStream(bytes3))
                {

                    AuthSign.Image = Image.FromStream(ms);
                }

            }
        }

        private void AuthSign_Click(object sender, EventArgs e)
        {

        }
    }
}
