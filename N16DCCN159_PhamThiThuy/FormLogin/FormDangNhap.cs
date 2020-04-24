using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txUsername.Text.Trim() == "" || txPassword.Text.Trim() == "" || textServerName.Text.Trim() == "")
            {
                MessageBox.Show("Server name, Login name và password không được trống", "", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = txUsername.Text.Trim();
            Program.password = txPassword.Text.Trim();
            Program.servername = textServerName.Text.Trim();

            // Đăng nhập thất bại
            if (Program.KetNoi() == 0) return;

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            Program.conn.Close();

            this.Hide();
            Program.frmMain = new FormMain();
            Program.frmMain.Activate();
            Program.frmMain.ShowDialog();
            this.Close();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textServerName.Text = Program.servername;
            txUsername.Text = Program.mlogin;
            txPassword.Text = Program.password;
        }
    }
}
