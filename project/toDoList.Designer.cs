
namespace project
{
    partial class toDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.add_todo = new System.Windows.Forms.GroupBox();
            this.add_button = new System.Windows.Forms.Button();
            this.content_todo = new System.Windows.Forms.TextBox();
            this.export_to_csv = new System.Windows.Forms.Button();
            this.remove_selected = new System.Windows.Forms.Button();
            this.remove_all = new System.Windows.Forms.Button();
            this.tasksDataGridView = new System.Windows.Forms.DataGridView();
            this.completedBtn = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.add_todo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(146, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(88, 25);
            this.title.TabIndex = 0;
            this.title.Text = "ToDo List";
            // 
            // add_todo
            // 
            this.add_todo.Controls.Add(this.add_button);
            this.add_todo.Controls.Add(this.content_todo);
            this.add_todo.Location = new System.Drawing.Point(12, 37);
            this.add_todo.Name = "add_todo";
            this.add_todo.Size = new System.Drawing.Size(351, 105);
            this.add_todo.TabIndex = 1;
            this.add_todo.TabStop = false;
            this.add_todo.Text = "Dodaj zadanie";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(0, 65);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(350, 25);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Dodaj";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // content_todo
            // 
            this.content_todo.Location = new System.Drawing.Point(0, 36);
            this.content_todo.Name = "content_todo";
            this.content_todo.Size = new System.Drawing.Size(350, 23);
            this.content_todo.TabIndex = 0;
            // 
            // export_to_csv
            // 
            this.export_to_csv.BackColor = System.Drawing.Color.White;
            this.export_to_csv.Location = new System.Drawing.Point(12, 494);
            this.export_to_csv.Name = "export_to_csv";
            this.export_to_csv.Size = new System.Drawing.Size(350, 25);
            this.export_to_csv.TabIndex = 3;
            this.export_to_csv.Text = "Eksportuj do CSV";
            this.export_to_csv.UseVisualStyleBackColor = false;
            this.export_to_csv.Click += new System.EventHandler(this.export_to_csv_Click);
            // 
            // remove_selected
            // 
            this.remove_selected.BackColor = System.Drawing.Color.White;
            this.remove_selected.Location = new System.Drawing.Point(12, 158);
            this.remove_selected.Name = "remove_selected";
            this.remove_selected.Size = new System.Drawing.Size(170, 25);
            this.remove_selected.TabIndex = 4;
            this.remove_selected.Text = "Usuń zaznaczone";
            this.remove_selected.UseVisualStyleBackColor = false;
            this.remove_selected.Click += new System.EventHandler(this.remove_selected_Click);
            // 
            // remove_all
            // 
            this.remove_all.BackColor = System.Drawing.Color.White;
            this.remove_all.Location = new System.Drawing.Point(193, 158);
            this.remove_all.Name = "remove_all";
            this.remove_all.Size = new System.Drawing.Size(170, 25);
            this.remove_all.TabIndex = 5;
            this.remove_all.Text = "Usuń zakończone";
            this.remove_all.UseVisualStyleBackColor = false;
            this.remove_all.Click += new System.EventHandler(this.remove_all_Click);
            // 
            // tasksDataGridView
            // 
            this.tasksDataGridView.AllowUserToAddRows = false;
            this.tasksDataGridView.AllowUserToDeleteRows = false;
            this.tasksDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.tasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksDataGridView.Location = new System.Drawing.Point(12, 187);
            this.tasksDataGridView.Name = "tasksDataGridView";
            this.tasksDataGridView.ReadOnly = true;
            this.tasksDataGridView.RowTemplate.Height = 25;
            this.tasksDataGridView.Size = new System.Drawing.Size(350, 250);
            this.tasksDataGridView.TabIndex = 6;
            // 
            // completedBtn
            // 
            this.completedBtn.BackColor = System.Drawing.Color.White;
            this.completedBtn.Location = new System.Drawing.Point(12, 443);
            this.completedBtn.Name = "completedBtn";
            this.completedBtn.Size = new System.Drawing.Size(350, 30);
            this.completedBtn.TabIndex = 7;
            this.completedBtn.Text = "Ukończone/Nieukończone";
            this.completedBtn.UseVisualStyleBackColor = false;
            this.completedBtn.Click += new System.EventHandler(this.completedBtn_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // toDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 532);
            this.Controls.Add(this.completedBtn);
            this.Controls.Add(this.tasksDataGridView);
            this.Controls.Add(this.remove_all);
            this.Controls.Add(this.remove_selected);
            this.Controls.Add(this.export_to_csv);
            this.Controls.Add(this.add_todo);
            this.Controls.Add(this.title);
            this.Name = "toDoList";
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.toDoList_Load);
            this.add_todo.ResumeLayout(false);
            this.add_todo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox add_todo;
        private System.Windows.Forms.TextBox content_todo;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button export_to_csv;
        private System.Windows.Forms.Button remove_selected;
        private System.Windows.Forms.Button remove_all;
        private System.Windows.Forms.DataGridView tasksDataGridView;
        private System.Windows.Forms.Button completedBtn;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
    }
}

