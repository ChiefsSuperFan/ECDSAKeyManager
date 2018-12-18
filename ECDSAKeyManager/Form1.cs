using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECDSAKeyManager
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileURL.Text = openFileDialog1.FileName;
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtMAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHash_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtFileURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            string fileHash = ECDSAOperations.GetSha256FileHash(txtFileURL.Text);

            if(fileHash.Length>0)
            {
                txtHash.Text = fileHash;

                string signature = ECDSAOperations.SignMessage(txtPrivateKey.Text, fileHash);
                txtMAC.Text = signature;

            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            UserAccount userAccount = new UserAccount();
            txtPrivateKey.Text = userAccount.ECDSAPrivateKey;
            txtPublicKey.Text = userAccount.ECSDAPublicKey;
            txtUserAddress.Text = userAccount.UserAddress;
            txtPrKeyLen.Text = userAccount.ECDSAPrivateKey.Length.ToString();
            txtPubKeyLen.Text = userAccount.ECSDAPublicKey.Length.ToString();
            txtAddrLen.Text = userAccount.UserAddress.Length.ToString();

            

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string signature = txtMAC.Text;
            string publicKey = txtPublicKey.Text;
            string hashValue = txtHash.Text;


            bool verify = ECDSAOperations.VerifySignature(hashValue, signature, publicKey);



        }
    }
}
