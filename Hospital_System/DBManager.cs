using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  
  * *  
   * * *   DEsigned ByE MaD TeAm 
                                  * * * 
                                     * *
                                        */
 
namespace Hospital_System
{
    class DBManager
    {
        //class members

        public const string connectionString = "server=localhost;database=hospital;uid=root;pwd=1234rewq";
        public MySqlConnection con;
        MySqlDataAdapter adapter;
        DataTable table;
        MySqlCommand command;

        public DBManager()
        {
            con = new MySqlConnection(connectionString);
            table = new DataTable();

        }

        //methods

        // open method to open the connection
        public void open()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void close()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable getTAble(String query, int columnNumbers, string[] names)
        {
            adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);
            for (int i = 0; i < columnNumbers; i++)
            {
                table.Columns[i].ColumnName = names[i];
            }
            return table;
        }
        public DataTable getTAble(String query)
        {
            DataTable table2 = new DataTable();
            try
            {

                adapter = new MySqlDataAdapter(query, con);
                adapter.Fill(table2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table2;

        }

        public void insertAndModifyDoctor(string query, string name, string address, int salary, string specialist, string phone = "", string id = "")
        {
            try
            {
                command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@v1", name);
                command.Parameters.AddWithValue("@v2", address);
                command.Parameters.AddWithValue("@v3", salary);
                command.Parameters.AddWithValue("@v4", specialist);
                command.Parameters.AddWithValue("@v5", phone);
                if (id != "")
                {
                    command.Parameters.AddWithValue("@v6", id);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Update successfully");
                }
                else
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Add successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void insertAndModifyNurse(string query, string name, string address, int salary, string phone = "", string id = "")
        {
            try
            {
                command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@v1", name);
                command.Parameters.AddWithValue("@v2", address);
                command.Parameters.AddWithValue("@v3", salary);
                command.Parameters.AddWithValue("@v4", phone);
                if (id != "")
                {
                    // Ubdate not Insert
                    command.Parameters.AddWithValue("@v5", id);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Update successfully");
                }
                else
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Add successfully");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insertPatient(string query, string name, string address = "", int age = 25, string gender = "male", int room = 5, string phone = "", string date = "")
        {

            try
            {

                command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@v1", name);
                command.Parameters.AddWithValue("@v2", address);
                command.Parameters.AddWithValue("@v3", phone);
                command.Parameters.AddWithValue("@v4", gender);
                command.Parameters.AddWithValue("@v5", age);
                command.Parameters.AddWithValue("@v6", room);
                command.Parameters.AddWithValue("@v7", date);
                command.ExecuteNonQuery();
                MessageBox.Show("Add successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void insertBill(string query, string date, int days , float amount,int patient_id)
        {

            try
            {

                command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@v1", date);
                command.Parameters.AddWithValue("@v2", days);
                command.Parameters.AddWithValue("@v3", amount);
                command.Parameters.AddWithValue("@v4", patient_id);
                command.ExecuteNonQuery();
                MessageBox.Show("Add successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void insertAndModifyRoom(string query, string name, string status, int nurse, string room_id = "")
        {
            try
            {
                command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@v1", name);
                command.Parameters.AddWithValue("@v2", status);
                command.Parameters.AddWithValue("@v3", nurse);

                if (room_id != "")
                {
                    // Ubdate not Insert
                    command.Parameters.AddWithValue("@v4", room_id);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Update successfully");
                }
                else
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Add successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void deleteFromTable(string query, int id)
        {
            try
            {
                command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@v1", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Delete Successfuly");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void BackUp()
        {
            try
            {
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
                    close();
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                mb.ExportToFile(folderPath + "\\Hospital_backup " + DateTime.Now.ToString("yyyy,MM,dd-HH,mm,ss") + ".sql");
                                conn.Close();

                            }
                        }
                    }
                    MessageBox.Show("تم انشاء نسخه احتياطيه بنجاح");
                    open();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Retore()
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "sql|*.sql";
            DialogResult res = of.ShowDialog();
            if (res == DialogResult.OK)
            {
                try
                {
                    close();
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                mb.ImportFromFile(of.FileName);
                                close();
                            }
                        }
                    }
                    open();
                    MessageBox.Show("تمت الاستعاده بنجاح");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
