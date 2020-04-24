using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace FormLogin
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        private String tenDevice;
        private int banSaoLuu = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.backup_devices' table. You can move, or remove it, as needed.
            this.tbAdapterBackupDevice.Fill(this.dS.backup_devices);

            // Set maxsize
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            // TODO: This line of code loads data into the 'dS.databases' table. You can move, or remove it, as needed.
            this.tbAdapterDatabases.Connection.ConnectionString = Program.connstr;
            this.tbAdapterDatabases.Fill(this.dS.databases);

            this.tbAdapterBackupDevice.Connection.ConnectionString = Program.connstr;
            this.tbAdapterBackupDevice.Fill(this.dS.backup_devices);

            Program.databaseName = ((DataRowView)this.bdsDatabases.Current).Row["name"].ToString();
            this.tbAdapterSttBackup.Fill(this.dS.SP_STT_BACKUP, Program.databaseName);

            bdsDatabases.Position = 0;

            databasesGridControl_Click(sender, e);
            dateStop.DateTime = DateTime.Now.Date;
            timeStop.Time = DateTime.Now;

            // Hide views
            progress.Visible = false;
            gcDatetime.Visible = cbDelAll.Checked = false;

            // show hide view
            lbTenDatabase.Text = ((DataRowView)this.bdsDatabases.Current).Row["name"].ToString();
            CheckDeviceExist();
        }

        private void btnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lbTenDatabase.Text.Trim() == "" || tenDevice == "") return;
            String strBackup = "BACKUP DATABASE " + lbTenDatabase.Text.Trim() + " TO " + tenDevice;
            if (cbDelAll.Checked == true)
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa các bản sao lưu cũ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    strBackup = strBackup + " WITH INIT";
                else return;
            int err = Program.ExecSqlNonQuery(strBackup, Program.connstr, "");
            if (err != 0)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu " + lbTenDatabase.Text.Trim());
                return;
            }
            progress.Visible = true;
            for (int i = this.progress.Minimum; i <= this.progress.Maximum; i++)
                progress.Value = i;
            progress.Visible = false;
            cbDelAll.Checked = false;
            MessageBox.Show("Đã sao lưu cơ sở dữ liệu!");
            //Tải lại các bản sao lưu, gồm cả bản vừa mới sao lưu
            LoadCacBanSaoLuu();
        }

        private void LoadCacBanSaoLuu()
        {
            if (lbTenDatabase.Text.Trim() == "") return;
            try
            {
                Program.databaseName = ((DataRowView)this.bdsDatabases.Current).Row["name"].ToString();
                this.tbAdapterSttBackup.Connection.ConnectionString = Program.connstr;
                this.tbAdapterSttBackup.Fill(this.dS.SP_STT_BACKUP, Program.databaseName);
                lbTenDatabase.Text = Program.databaseName;

                if (bdsSPSttBackup.Count == 0) banSaoLuu = 0;
                else banSaoLuu = int.Parse(((DataRowView)bdsSPSttBackup[0])["position"].ToString());

                lbSoBanSaoLuu.Text = banSaoLuu.ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.bdsSPSttBackup.Count == 0)
            {
                MessageBox.Show("Chưa có bản sao lưu để phục hồi", "", MessageBoxButtons.OK);
                return;
            }
            if (banSaoLuu == 0)
            {
                MessageBox.Show("Chưa chọn một bản sao lưu để phục hồi", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close(); // đóng kết nối

            progress.Visible = true;
            int i;
            for (i = this.progress.Minimum; i <= this.progress.Maximum / 4; i++)
                progress.Value = i;

            if (lbTenDatabase.Text.Trim() == "" || tenDevice == "") return;

            // ngắt kết nối các database
            String strRestore = "ALTER DATABASE " + lbTenDatabase.Text.Trim()
                + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE ";

            // Phục hồi về thời điểm đã sao lưu
            if (cbThamSoTheoTg.Checked == false)
            {
                strRestore += " USE tempdb RESTORE DATABASE " + lbTenDatabase.Text.Trim()
                    + " FROM   " + tenDevice + " WITH FILE =  " + banSaoLuu + ", REPLACE "
                    + "ALTER DATABASE  " + lbTenDatabase.Text.Trim() + " SET MULTI_USER";

                int err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi phục hồi cơ sở dữ liệu.");
                if (err == 0)
                {
                    progress.Visible = true;
                    for (; i <= this.progress.Maximum; i++)
                        progress.Value = i;
                    progress.Visible = false;
                    MessageBox.Show("Phục hồi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else progress.Visible = false; return;
            }
            // Backup đên 1 thời gian nào đ
            else
            {
                // Ngày giờ stop at > thời điểm sao lưu và nhỏ hơn thời điểm hiện tại ít nhất 3p\
                // Ngày giờ của bản backup được chọn
                DateTime ngaygioBK = (DateTime)((DataRowView)bdsSPSttBackup[bdsSPSttBackup.Position])["backup_start_date"];

                // ngày h của user nhập
                String strThoiDiemStopAt = dateStop.DateTime.Year + "-" + dateStop.DateTime.Month + "-" + dateStop.DateTime.Day + " " +
                    timeStop.Time.Hour + ":" + timeStop.Time.Minute + ":" + timeStop.Time.Second;

                DateTime thoiDiemStopAt = DateTime.Now;

                try
                {
                    // format Ngày giờ người dùng nhập
                    thoiDiemStopAt = DateTime.Parse(strThoiDiemStopAt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi convert ngày" + ex.Message, "", MessageBoxButtons.OK);
                    progress.Visible = false;
                }

                // Kiểm tra sau thời điểm hiện tại
                if (thoiDiemStopAt > DateTime.Now)
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải trước thời điểm hiện tại", "", MessageBoxButtons.OK);
                    progress.Visible = false;
                    return;
                }

                //if (dateStop.DateTime.Date <= ngaygioBK.Date
                //    || thoiDiemStopAt.TimeOfDay.Ticks < ngaygioBK.TimeOfDay.Ticks)
                if (DateTime.Compare(thoiDiemStopAt, ngaygioBK) <=0  )
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải sau thời điểm bản sao lưu đã chọn", "", MessageBoxButtons.OK);
                    progress.Visible = false;
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn phục hồi database " + Program.databaseName + "về ngày " + ngaygioBK + "?"
                    , "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        // Restore về 1 thời điểm người dùng nhập
                        strRestore += " BACKUP LOG " + Program.databaseName +
                             " TO DISK = '" + Program.defaultPath + "DEVICE_" + Program.databaseName + ".trn' WITH NORECOVERY " +
                             " RESTORE DATABASE " + Program.databaseName +
                             " FROM  DEVICE_" + Program.databaseName + " WITH FILE = 2, NORECOVERY " +
                             " RESTORE DATABASE " + Program.databaseName +
                             " FROM DISK = '" + Program.defaultPath + "DEVICE_" + Program.databaseName + ".trn' " +
                             " WITH STOPAT= '" + thoiDiemStopAt + "' " +
                             " ALTER DATABASE  " + Program.databaseName + " SET MULTI_USER ";

                        int err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi phục hồi cơ sở dữ liệu.");
                        if (err == 0)
                        {
                            progress.Visible = true;
                            for (; i <= this.progress.Maximum; i++)
                                progress.Value = i;
                            progress.Visible = false;
                            MessageBox.Show("Phục hồi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                        else progress.Visible = false; return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi Restore:\n" + ex, "Xảy ra lỗi", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    progress.Visible = false;
                }
            }
        }

        private void cbThamSoTheoTg_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbThamSoTheoTg.Checked == true) gcDatetime.Visible = true;
            else gcDatetime.Visible = false;
        }

        private void ShowCreateDevice()
        {
            btnSaoLuu.Enabled = btnPhucHoi.Enabled = cbThamSoTheoTg.Enabled = false;
            btnTaoDeviceSaoLuu.Enabled = btnThoat.Enabled = true;
        }

        private void HideCreateDevice()
        {
            btnSaoLuu.Enabled = btnPhucHoi.Enabled = cbThamSoTheoTg.Enabled = btnThoat.Enabled = true;
            btnTaoDeviceSaoLuu.Enabled = false;
        }


        // Check device exist? 
        private void CheckDeviceExist()
        {
            String strTenDevice = "select  COUNT(name) from  sys.backup_devices WHERE name = N'DEVICE_"
               + lbTenDatabase.Text.Trim() + "'";

            Program.myReader = Program.ExecSqlDataReader(strTenDevice);
            if (Program.myReader == null) return;

            Program.myReader.Read();

            //Nếu đã có device, hiện các button khác, ẩn button tạo device đi
            if (Program.myReader.GetInt32(0) > 0)
            {
                HideCreateDevice();
                tenDevice = "DEVICE_" + lbTenDatabase.Text.Trim();
            }
            //Nếu chưa có device, ẩn các button khác, chỉ hiện button device và button thoát
            else ShowCreateDevice();
            Program.myReader.Close();

        }

        private void databasesGridControl_Click(object sender, EventArgs e)
        {
            Program.databaseName = ((DataRowView)this.bdsDatabases.Current).Row["name"].ToString();
            this.tbAdapterSttBackup.Fill(this.dS.SP_STT_BACKUP, Program.databaseName);
            lbTenDatabase.Text = Program.databaseName;

            if (bdsSPSttBackup.Count == 0) banSaoLuu = 0;
            else banSaoLuu = int.Parse(((DataRowView)bdsSPSttBackup[0])["position"].ToString());
            lbSoBanSaoLuu.Text = banSaoLuu.ToString();

            CheckDeviceExist();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else e.Cancel = true;
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Program.mlogin = "";
                Program.password = "";
                this.Hide();
                Program.frmLogin = new FormDangNhap();
                Program.frmLogin.Activate();
                Program.frmLogin.ShowDialog();
                this.Close();
            }
            else return;
        }

        private void btnXoaBackup_Click(object sender, EventArgs e)
        {
            if (bdsSPSttBackup.Count == 0)
            {
                MessageBox.Show("Không có bản backup nào để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản backup " + ((DataRowView)this.bdsSPSttBackup.Current).Row["name"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giảng viên " + ex.Message, "", MessageBoxButtons.OK);
                }
            }

        }

        private void TaoDevice()
        {
            // Lưu trên disk
            String strTaoDevice = "EXEC sp_addumpdevice 'disk', 'DEVICE_" + lbTenDatabase.Text.Trim() + "', " +
                "'" + Program.defaultPath + "DEVICE_" + lbTenDatabase.Text.Trim() + ".bak' ";

            int err = Program.ExecSqlNonQuery(strTaoDevice, Program.connstr, "Lỗi tạo device.");
            if (err == 0)
            {
                progress.Visible = true;
                for (int i = progress.Minimum; i <= this.progress.Maximum; i++)
                    progress.Value = i;
                progress.Visible = false;

                // Show message diaglog create device successfull
                MessageBox.Show("Tạo device thành công!", "Thông báo", MessageBoxButtons.OK);
                HideCreateDevice();
            }
            else
            {
                ShowCreateDevice();
                progress.Visible = false; return;
            }
        }

        private void btnTaoDeviceSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Check folder default
            // if exist 
            if (Directory.Exists(Program.defaultPath) == true)
            {
                TaoDevice();
            }
            // If doesn't exist --> allow user choose a path to create device
            else
            {
                //using (var fbd = new FolderBrowserDialog())
                //{
                //    DialogResult result = fbd.ShowDialog();

                //    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                //    {
                //        string[] files = Directory.GetFiles(fbd.SelectedPath);
                //        Program.defaultPath = files.ToString()+"\\";
                //        TaoDevice();
                //    }
                //}
                OpenFileDialog folderBrowser = new OpenFileDialog();
                // Set validate names and check file exists to false otherwise windows will
                // not let you select "Folder Selection."
                folderBrowser.ValidateNames = false;
                folderBrowser.CheckFileExists = false;
                folderBrowser.CheckPathExists = true;
                // Always default to Folder Selection.
                folderBrowser.FileName = "Folder Selection.";
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                    Program.defaultPath = folderPath + "\\";
                    TaoDevice();
                }

            }
        }

        private void sP_STT_BACKUPGridControl_Click(object sender, EventArgs e)
        {
            banSaoLuu = int.Parse(((DataRowView)bdsSPSttBackup.Current)["position"].ToString());
            lbSoBanSaoLuu.Text = banSaoLuu.ToString();
        }
    }
}