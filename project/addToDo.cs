using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace project
{
    public partial class toDoList
    {
        private void add_button_Click(object sender, EventArgs e)
        {
            string content = content_todo.Text;
            string query = "INSERT INTO todos (content, is_completed) VALUES ('" + content + "', 0" +
                ")";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
            content_todo.Text = "";
            toDoList_Load(this, null);
        }
    }
}