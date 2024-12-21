using System;
using System.Linq;
using System.Windows.Forms;

namespace TaskManagerApp
{
    public partial class Form1 : Form
    {
        private TaskManager taskManager;

        public Form1()
        {
            InitializeComponent();
            taskManager = new TaskManager();
        }

        // Add Task Button Click Event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string description = txtDescription.Text;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please enter both title and description.");
                return;
            }

            taskManager.AddTask(title, description);
            RefreshTaskList();

            // Clear the textboxes
            txtTitle.Clear();
            txtDescription.Clear();

        }


        // View Task List Button Click Event
        private void btnView_Click(object sender, EventArgs e)
        {
            RefreshTaskList();
        }

        // Edit Task Button Click Event
        // Edit Task Button Click Event
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTasks1.SelectedItem == null)
            {
                MessageBox.Show("Please select a task to edit.");
                return;
            }

            var task = lstTasks1.SelectedItem as Task;

            if (task == null) return;

            string newTitle = txtTitle.Text;
            string newDescription = txtDescription.Text;

            if (string.IsNullOrEmpty(newTitle) || string.IsNullOrEmpty(newDescription))
            {
                MessageBox.Show("Please enter both a title and description to edit the task.");
                return;
            }

            taskManager.EditTask(task.Id, newTitle, newDescription);
            RefreshTaskList();

            // Clear the textboxes after editing
            txtTitle.Clear();
            txtDescription.Clear();

            MessageBox.Show("Task updated successfully.");
        }


        // Delete Task Button Click Event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks1.SelectedItem == null) return;

            var task = lstTasks1.SelectedItem as Task;
            taskManager.DeleteTask(task.Id);
            RefreshTaskList();
        }

        // Mark Task as Complete Button Click Event
        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (lstTasks1.SelectedItem == null) return;

            var task = lstTasks1.SelectedItem as Task;
            taskManager.MarkTaskComplete(task.Id);
            RefreshTaskList();
           
        }

        // Refresh the task list (ListBox)
        private void RefreshTaskList()
        {
            lstTasks1.Items.Clear();
            var tasks = taskManager.GetTasks();
            if (!tasks.Any())
            {
                lstTasks1.Items.Add("No tasks available.");
                return;
            }

            foreach (var task in tasks)
            {
                lstTasks1.Items.Add(task);
            }
        }

        private void lstTasks1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasks1.SelectedItem == null) return;

            var task = lstTasks1.SelectedItem as Task;
            if (task != null)
            {
                txtTitle.Text = task.Title;
                txtDescription.Text = task.Description;
            }
        }
       
    }
}

