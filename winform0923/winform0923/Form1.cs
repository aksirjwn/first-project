using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;

namespace winform0923
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var conn = new OracleConnection())
            {
                conn.ConnectionString = "data source=localhost;user id=SYSTEM;password=1234;";
                conn.Open();

                using (var cmd1 = new OracleCommand())
                {
                    cmd1.Connection = conn;
                    cmd1.CommandText = "select * from hi";
                    var rdr = cmd1.ExecuteReader();
                    Debug.WriteLine(rdr.Read());
                    
                }


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}