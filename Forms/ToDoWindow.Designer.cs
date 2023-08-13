namespace Work_Tool.Forms
{
    partial class ToDoWindow
    {
        private ListBox listBoxToDo;
        private List<ToDoItem> toDoList;


        #region useless built in
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxToDo = new ListBox { Location = new System.Drawing.Point(10, 10), Size = new System.Drawing.Size(300, 200) };
            Button btnAdd = new Button { Text = "Aggiungi", Location = new System.Drawing.Point(320, 10) };
            Button btnEdit = new Button { Text = "Modifica", Location = new System.Drawing.Point(320, 40) };
            Button btnDelete = new Button { Text = "Elimina", Location = new System.Drawing.Point(320, 70) };
            Button btnToggleComplete = new Button { Text = "Completa/Annulla", Location = new System.Drawing.Point(320, 100) };

            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnToggleComplete.Click += BtnToggleComplete_Click;

            Controls.Add(listBoxToDo);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnToggleComplete);

            Text = "Cose da Fare";
            Width = 450;
            Height = 250;
        }

        #endregion

        #region Events
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string taskDescription = PromptDialog.PromptDialog.ShowDialog("Inserisci l'attività:", "Nuova Attività");
            if (!string.IsNullOrEmpty(taskDescription))
            {
                toDoList.Add(new ToDoItem(taskDescription));
                RefreshToDoList();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxToDo.SelectedItem is ToDoItem selectedItem)
            {
                string newDescription = PromptDialog.PromptDialog.ShowDialog("Modifica l'attività:", "Modifica Attività", selectedItem.Task);
                if (!string.IsNullOrEmpty(newDescription))
                {
                    selectedItem.Task = newDescription;
                    RefreshToDoList();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxToDo.SelectedItem is ToDoItem selectedItem)
            {
                toDoList.Remove(selectedItem);
                RefreshToDoList();
            }
        }

        private void BtnToggleComplete_Click(object sender, EventArgs e)
        {
            if (listBoxToDo.SelectedItem is ToDoItem selectedItem)
            {
                selectedItem.IsCompleted = !selectedItem.IsCompleted;
                RefreshToDoList();
            }
        }

        private void RefreshToDoList()
        {
            listBoxToDo.Items.Clear();
            listBoxToDo.Items.AddRange(toDoList.ToArray());
        }
        #endregion
    }
}