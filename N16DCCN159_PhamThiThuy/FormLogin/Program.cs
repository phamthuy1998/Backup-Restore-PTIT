using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data;
using System.Data.SqlClient;


namespace FormLogin
{
    static class Program
    {

        public static FormMain frmMain;
        public static FormDangNhap frmLogin;

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;
        public static String servername = "THUY";
        public static String mlogin = "sa";
        public static String password = "123";
        public static String databaseName = "";

        // đường dẫn mặc định nếu muốn sửa thì sẽ không được--> cần chỉnh sủa code 
        // sao cho khi đổi máy vẫn có thể chạy được
        // Mặc định sẽ mở đường dẫn này, khi tạo device kiểm tra đường dẫn có tồn tại hay không
        // Nếu tồn tại thì lưu trong đường dẫn,  ngược lại mở folder cho người dùng chọn đường dẫn để lưu
        public static String defaultPath = "D:/Backup_Restore_DB/";



        public static int namBatDau = 2016;
        public static int flagRestore = 0;// Cờ kiểm tra use có phục hồi lại csdl

        public static String mlogin1 = "HTKN";
        public static String password1 = "123";
        public static String connstr1;
        public static String servername1 = "";
        public static SqlConnection conn1 = new SqlConnection();

        public static String database = "TN";
        public static String remotelogin = "sa";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mCoSo = 0;
        public static String mTenCoSo = "";

        public static BindingSource bds_dsLop = new BindingSource();
        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
                                                                     //public static frmMain frmChinh;
        public static SqlDataReader dtKhoa;
        public static int KetNoiCosoKhac()
        {
            if (Program.conn1 != null && Program.conn1.State == ConnectionState.Open)
                Program.conn1.Close();
            try
            {
                Program.connstr1 = "Data Source=" + Program.servername1 + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin1 + ";password=" + Program.password1;
                Program.conn1.ConnectionString = Program.connstr1;
                Program.conn1.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n "
                    + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static int ExecSqlNonQuery(String strlenh, String connectionString, String errStr)
        {
            conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(errStr + "\n" + ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n "
                    + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }



        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            conn.Close();
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            //tối đa cho đợi 10p, tgian tính bằng s
            sqlcmd.CommandTimeout = 600;
            // Kiểm tra trạng thái đóng hay mở
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static SqlDataReader ExecSqlDataReader1(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn1);
            sqlcmd.CommandType = CommandType.Text;
            //tối đa cho đợi 10p, tgian tính bằng s
            sqlcmd.CommandTimeout = 600;
            // Kiểm tra trạng thái đóng hay mở
            if (Program.conn1.State == ConnectionState.Closed) Program.conn1.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn1.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            // Trả về datable
            DataTable dt = new DataTable();
            //Nếu đang đóng thì mở
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            // Muốn gọi csdl phải thông qua SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            // Chạy lệnh cmd
            da.Fill(dt);
            conn.Close();
            return dt;
        }


        public static DataTable ExecSqlDataTable1(String cmd)
        {
            // Trả về datable
            DataTable dt = new DataTable();
            //Nếu đang đóng thì mở
            if (Program.conn1.State == ConnectionState.Closed) Program.conn1.Open();
            // Muốn gọi csdl phải thông qua SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn1);
            // Chạy lệnh cmd
            da.Fill(dt);
            conn1.Close();
            return dt;
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new FormDangNhap();
            Application.Run( frmLogin);
        }
    }
}
