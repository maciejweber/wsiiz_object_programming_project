using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project
{
    public partial class toDoList : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public toDoList()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            server = "localhost";
            database = "todolist";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void toDoList_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM todos";
            this.CustomizeDataGridView();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    this.tasksDataGridView.Rows.Add(rdr.GetValue(0), rdr.GetValue(1), rdr.GetValue(2));
                }

                this.CloseConnection();
            }
        }

        private void CustomizeDataGridView()
        {
            this.tasksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.tasksDataGridView.MultiSelect = false;
            this.tasksDataGridView.AutoGenerateColumns = false;
            this.tasksDataGridView.AllowUserToResizeRows = false;

            this.tasksDataGridView.ReadOnly = true;
            this.tasksDataGridView.RowHeadersVisible = false;

            this.tasksDataGridView.Columns.Clear();

            var columnId = new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID" };
            var columnTask = new DataGridViewTextBoxColumn { DataPropertyName = "Zadanie", HeaderText = "Zadanie", Width = 250 };
            var columnIsCompleted = new DataGridViewTextBoxColumn { DataPropertyName = "Wykonane", HeaderText = "Wykonane", Width = 97 };
            columnId.Visible = false;

            this.tasksDataGridView.Columns.AddRange(new[] { columnId, columnTask, columnIsCompleted });
        }

    }
}

