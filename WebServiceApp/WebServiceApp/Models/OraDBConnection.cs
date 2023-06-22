using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceApp.Models
{
    public class OraDBConnection
    {
        static string Userid = "";
        static string password = "";
        static string datasorce = "";
        public static void SetConnectiondata(string userid, string Pwd, string datasource)
        {
            Userid = userid;
            password = Pwd;
            datasorce = datasource;
        }


        public static string OrclConnection
        {
            get
            {
                string _oraConn = "User Id=" + Userid + ";Password=" + password + ";" + "Data source=" + datasorce + "";
                //string _oraConn = "User Id=FINANCE;Password=" + password + ";" + "Data source=" + datasorce + "";
                //string _oraConn = "User Id=FINANCE;Password=Fin;"+"Data source=192.168.1.13:1521/KUMA";
                // _oraConn = MawaiConnection;
                //_oraConn =System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionStrings: DefaultConnection"].ToString();
                //var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                //IConfigurationRoot configuration = builder.Build();
                //string _oraConn = configuration.GetConnectionString("DefaultConnection");
                return _oraConn;
            }
        }

        public static OracleConnection connection(String connectionString)
        {
            OracleConnection conn = null;
            using (conn = new OracleConnection(connectionString))
            {
                conn.Open();
            }
            return conn;
        }
    }
}
