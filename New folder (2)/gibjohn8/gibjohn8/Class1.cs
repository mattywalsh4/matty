using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace gibjohn8
{
    public class Account
    {
        public string Uname { get; set; }
        public int? ID { get; set; }
    }
    class Class1
    {
        OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M:\Task 2\New folder (2)\gibjohn8\DB\Database11.accdb");

        public bool login(string username, string password)
        {
            if (username != "" && password != "")
            {
                conn.Open();

                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("SELECT * FROM [Accounts] WHERE username ='" + username + "' AND password = '" + password + "'", conn);

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Account acc = new Account
                    {
                        Uname = username,
                        ID = (int)reader[0],
                    };
                    string json = JsonConvert.SerializeObject(acc, Formatting.Indented);
                    System.IO.File.WriteAllText(@"M:\Task 2\New folder (2)\gibjohn8\gibjohn8\account.json", json);
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void change(string data, string type)
        {
            if (data != "")
            {
                Account acc = JsonConvert.DeserializeObject<Account>(File.ReadAllText(@"M:\Task 2\New folder (2)\gibjohn8\gibjohn8\account.json"));
                conn.Open();
                OleDbCommand command = new OleDbCommand("UPDATE Accounts SET [" + type + "] = '" + data + "' WHERE ID = " + acc.ID + "", conn);
                command.ExecuteReader();
                conn.Close();
                Console.WriteLine("Success");

            }
            else
            {
                Console.WriteLine("No data entered");
            }
        }

    }


}
