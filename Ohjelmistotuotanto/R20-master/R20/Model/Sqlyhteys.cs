using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R20.Model
{
    
    internal class Sqlyhteys
    {
        public static string Server { get; set;}
        public  static string Port { get; set; }
        public static string UserID { get; set; }
        public static string Password { get; set; }
        public static string Database { get; set; }
        
        public static MySqlConnection connection()
        {
            try
            {
                MySqlConnection connection;
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = Server;
                builder.Port = uint.Parse(Port);
                builder.UserID = UserID;
                builder.Password = Password;
                builder.Database = Database;
                builder.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(builder.ToString());
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
