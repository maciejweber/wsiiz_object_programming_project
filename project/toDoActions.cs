using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace project
{
    public partial class toDoList
    {
        private void completedBtn_Click(object sender, EventArgs e)
        {
            int selected_index = tasksDataGridView.SelectedCells[0].RowIndex;
            if (tasksDataGridView.CurrentCell.Selected)
            {
                int selectedrowindex = tasksDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = tasksDataGridView.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[0].Value);

                string update = "UPDATE todos SET is_completed = NOT is_completed WHERE id =" + cellValue;
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(update, connection);
                    MySqlDataReader rdr = cmd.ExecuteReader();


                    this.CloseConnection();
                }
            }
            toDoList_Load(this, null);
            tasksDataGridView.Rows[selected_index].Selected = true;
        }

        private void remove_selected_Click(object sender, EventArgs e)
        {
            if (tasksDataGridView.CurrentCell.Selected)
            {
                int selectedrowindex = tasksDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = tasksDataGridView.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells[0].Value);
                string content = selectedRow.Cells[1].Value.ToString();

                if (MessageBox.Show("Delete task: " + content + "?", "Delete a Task", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                {
                    return;
                }

                string update = "DELETE FROM `todos` WHERE id =" + id;
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(update, connection);
                    MySqlDataReader rdr = cmd.ExecuteReader();


                    this.CloseConnection();
                }

                MessageBox.Show("Successfull deleted todo with id: " + id.ToString());
            }
            toDoList_Load(this, null);
        }

        private void remove_all_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete all completed tasks?", "Delete a Task", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            string query = "DELETE FROM todos WHERE is_completed = '1'";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                this.CloseConnection();
            }
            MessageBox.Show("Successfull deleted all completed todos");
            toDoList_Load(this, null);
        }

        private void export_to_csv_Click(object sender, EventArgs e)
        {
            if (tasksDataGridView.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < tasksDataGridView.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = tasksDataGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < tasksDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < tasksDataGridView.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = tasksDataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}

