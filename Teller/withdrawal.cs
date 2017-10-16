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
    public partial class withdrawal : Form
    {
        public withdrawal()
        {
            InitializeComponent();
            sigCtl = new SigCtl();
        }

        MySqlCommand cmd;
        SigCtl sigCtl;
        SigObj sigObj;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("host=localhost;Database=ktb;Uid=root;Pwd=;charset=tis620;");
            string sql = "SELECT * FROM withdrawal WHERE qr_code='" + txtQR.Text + "' ";
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
                else if (reader.GetString("deposit_by") == "รายการโอน")
                {
                    rdCash.Checked = true;
                    rdTransfer.Checked = false;
                    rdTotalCheq.Checked = false;
                }
                txtNameWith.Text = reader.GetString("name_receiver");
                txtTypeCard.Text = reader.GetString("type_card");
                txtIdNum.Text = reader.GetString("id_num");
                txtCreateBy.Text = reader.GetString("create_by");
                txtDateExpire.Text = reader.GetString("expire");
                comboBox2.Text = reader.GetString("cheq_num");
                txtAccounntNumber.Text = reader.GetString("account_num");
                txtBranch2.Text = reader.GetString("branch2");
                txtAccountName.Text = reader.GetString("account_name");
                txtAmount.Text = reader.GetString("amount");
                txtAmountText.Text = reader.GetString("amount_text");
                txtPhone.Text = reader.GetString("phone");
                txtTotalAmount.Text = reader.GetString("total_amount");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
            txtAmount.Text = "";
            comboBox2.Text = "";
            txtBranch.Text = "";
            txtBranch2.Text = "";
            rdCash.Checked = false;
            rdTransfer.Checked = false;
            rdTotalCheq.Checked = false;
            AccountOwnerSignature.Image = null;
            ReceiverSign.Image = null;
            AuthSign.Image = null;
            AuthSign.Image = null;
            Refresh();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms1 = new MemoryStream();
                AccountOwnerSignature.Image.Save(ms1, AccountOwnerSignature.Image.RawFormat);
                byte[] account_owner = ms1.ToArray();

                MemoryStream ms2 = new MemoryStream();
                ReceiverSign.Image.Save(ms2, ReceiverSign.Image.RawFormat);
                byte[] Reciever = ms2.ToArray();

                MemoryStream ms3 = new MemoryStream();
                AuthSign.Image.Save(ms3, AuthSign.Image.RawFormat);
                byte[] auth_sign = ms3.ToArray();

                String sql = "UPDATE withdrawal set account_owner_sign=@account_owner, receiver_sign=@receiver, auth_sign=@auth_sign WHERE qr_code=001";

                try
                {

                    MySqlConnection con = new MySqlConnection("host=localhost;Database=ktb;Uid=root;Pwd=;charset=tis620;");
                    cmd = new MySqlCommand(sql, con);
                    //CreateQ = new MySqlCommand(GenerateQ, con);
                    con.Open();

                    cmd.Parameters.Add("@account_owner", MySqlDbType.Blob);
                    cmd.Parameters.Add("@receiver", MySqlDbType.Blob);
                    cmd.Parameters.Add("@auth_sign", MySqlDbType.Blob);

                    cmd.Parameters["@account_owner"].Value = account_owner;
                    cmd.Parameters["@receiver"].Value = Reciever;
                    cmd.Parameters["@auth_sign"].Value = auth_sign;

                    cmd.ExecuteNonQuery();
                    //CreateQ.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Completed");
                    success_withdraw s = new success_withdraw();
                    s.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch
            {
                MessageBox.Show("No Signature");
            }
            
        }

        private void AuthSign_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text == "")
            {
                MessageBox.Show("Please Input data");
            }
            else
            {
                DynamicCapture dc = new DynamicCapture();
                DynamicCaptureResult res = dc.Capture(sigCtl, "ลายมือชื่อเจ้าหน้าที่", "แบบฟอร์มใบถอนเงิน", null, null);
                if (res == DynamicCaptureResult.DynCaptOK)
                {
                    sigObj = (SigObj)sigCtl.Signature;
                    sigObj.set_ExtraData("AdditionalData", "C# Test");
                    try
                    {
                        byte[] binaryData = sigObj.RenderBitmap("", 173, 79, "image/png", 1.5f, 0xff0000, 0xffffff, 10.0f, 10.0f, RBFlags.RenderOutputBinary | RBFlags.RenderColor32BPP) as byte[];
                        using (MemoryStream memStream = new MemoryStream(binaryData))
                        {
                            System.Drawing.Image newImage = System.Drawing.Image.FromStream(memStream);
                            AuthSign.Image = newImage;
                            memStream.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void AccountOwnerSignature_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text == "")
            {
                MessageBox.Show("Please Input data");
            }
            else
            {
                DynamicCapture dc = new DynamicCapture();
                DynamicCaptureResult res = dc.Capture(sigCtl, "ลายมือชื่อเจ้าของบัญชี", "แบบฟอร์มใบถอนเงิน", null, null);
                if (res == DynamicCaptureResult.DynCaptOK)
                {
                    sigObj = (SigObj)sigCtl.Signature;
                    sigObj.set_ExtraData("AdditionalData", "C# Test");
                    try
                    {
                        byte[] binaryData = sigObj.RenderBitmap("", 173, 79, "image/png", 1.5f, 0xff0000, 0xffffff, 10.0f, 10.0f, RBFlags.RenderOutputBinary | RBFlags.RenderColor32BPP) as byte[];
                        using (MemoryStream memStream = new MemoryStream(binaryData))
                        {
                            System.Drawing.Image newImage = System.Drawing.Image.FromStream(memStream);
                            AccountOwnerSignature.Image = newImage;
                            memStream.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void ReceiverSign_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text == "")
            {
                MessageBox.Show("Please Input data");
            }
            else
            {
                DynamicCapture dc = new DynamicCapture();
                DynamicCaptureResult res = dc.Capture(sigCtl, "ลายมือชื่อผู้รับเงิน", "แบบฟอร์มใบถอนเงิน", null, null);
                if (res == DynamicCaptureResult.DynCaptOK)
                {
                    sigObj = (SigObj)sigCtl.Signature;
                    sigObj.set_ExtraData("AdditionalData", "C# Test");
                    try
                    {
                        byte[] binaryData = sigObj.RenderBitmap("", 173, 79, "image/png", 1.5f, 0xff0000, 0xffffff, 10.0f, 10.0f, RBFlags.RenderOutputBinary | RBFlags.RenderColor32BPP) as byte[];
                        using (MemoryStream memStream = new MemoryStream(binaryData))
                        {
                            System.Drawing.Image newImage = System.Drawing.Image.FromStream(memStream);
                            ReceiverSign.Image = newImage;
                            memStream.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void txtQR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void txtQR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
