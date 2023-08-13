using Work_Tool.PromptDialog;

namespace Work_Tool.Forms
{
    partial class StudyWindow
    {
        private ListBox listBoxTopics;
        private List<Topic> studyTopics;

        #region built in code
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "StudyWindow";

            listBoxTopics = new ListBox { Location = new System.Drawing.Point(10, 10), Size = new System.Drawing.Size(300, 200) };
            Button btnAdd = new Button { Text = "Aggiungi", Location = new System.Drawing.Point(320, 10) };
            Button btnEdit = new Button { Text = "Modifica", Location = new System.Drawing.Point(320, 40) };
            Button btnDelete = new Button { Text = "Elimina", Location = new System.Drawing.Point(320, 70) };

            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;

            Controls.Add(listBoxTopics);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);

            Text = "Argomenti da Studiare";
            Width = 450;
            Height = 250;
        }

        #endregion

        #region event
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string subject = PromptDialog.PromptDialog.ShowDialog("Inserisci l'argomento:", "Nuovo Argomento");
            if (!string.IsNullOrEmpty(subject))
            {
                studyTopics.Add(new Topic());
                RefreshTopicsList();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxTopics.SelectedItem is Topic selectedTopic)
            {
                string newSubject = PromptDialog.PromptDialog.ShowDialog("Modifica l'argomento:", "Modifica Argomento", selectedTopic.Subject);
                if (!string.IsNullOrEmpty(newSubject))
                {
                    selectedTopic.Subject = newSubject;
                    RefreshTopicsList();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTopics.SelectedItem is Topic selectedTopic)
            {
                studyTopics.Remove(selectedTopic);
                RefreshTopicsList();
            }
        }

        private void RefreshTopicsList()
        {
            listBoxTopics.Items.Clear();
            listBoxTopics.Items.AddRange(studyTopics.ToArray());
        }
        #endregion
    }
}