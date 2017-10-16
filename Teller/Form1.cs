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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sigCtl = new SigCtl();
        }

        MySqlConnection con = new MySqlConnection("host=localhost;Database=ktb;Uid=root;Pwd=;charset=tis620;");
        MySqlCommand cmd;
        SigCtl sigCtl;
        SigObj sigObj;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM deposit WHERE qr_code='" + txtQR.Text + "' ";                
            cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtBranch.Text = reader.GetString("branch");
                txtTime.Text = reader.GetString("date");

                if(reader.GetString("deposit_by") == "เงินสด")
                {
                    rdCash.Checked = true;
                    rdTransfer.Checked = false;
                    rdTotalCheq.Checked = false;
                }
                else if(reader.GetString("deposit_by") == "รายการโอน")
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
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms1 = new MemoryStream();
                SignCus.Image.Save(ms1, SignCus.Image.RawFormat);
                byte[] cus_sign = ms1.ToArray();

                MemoryStream ms2 = new MemoryStream();
                AuthSign.Image.Save(ms2, AuthSign.Image.RawFormat);
                byte[] auth_sign = ms2.ToArray();

                String sql = "UPDATE deposit set sign_cus=@sign_cus,auth_sign=@auth_sign WHERE qr_code=001";

                try
                {

                    MySqlConnection con = new MySqlConnection("host=localhost;Database=ktb;Uid=root;Pwd=;charset=tis620;");
                    cmd = new MySqlCommand(sql, con);
                    //CreateQ = new MySqlCommand(GenerateQ, con);
                    con.Open();

                    cmd.Parameters.Add("@sign_cus", MySqlDbType.Blob);
                    cmd.Parameters.Add("@auth_sign", MySqlDbType.Blob);

                    cmd.Parameters["@sign_cus"].Value = cus_sign;
                    cmd.Parameters["@auth_sign"].Value = auth_sign;

                    cmd.ExecuteNonQuery();
                    //CreateQ.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Completed");
                    success suc = new success();
                    suc.ShowDialog();
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
                DynamicCaptureResult res = dc.Capture(sigCtl, "ลายมือชื่อเจ้าหน้าที่", "แบบฟอร์มใบรับฝากเงิน", null, null);
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
            rdCash.Checked = false;
            rdTransfer.Checked = false;
            rdTotalCheq.Checked = false;
            SignCus.Image = null;
            AuthSign.Image = null;
            Refresh();
        }

        private void SignCus_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text == "")
            {
                MessageBox.Show("Please Input data");
            }
            else
            {
                DynamicCapture dc = new DynamicCapture();
                DynamicCaptureResult res = dc.Capture(sigCtl, "ลายมือชื่อผู้ทำรายการ", "แบบฟอร์มใบรับฝากเงิน", null, null);
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
                            SignCus.Image = newImage;
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
    }
}
