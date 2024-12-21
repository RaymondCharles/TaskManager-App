using System.Collections.Generic;
using System.Linq;

namespace TaskManagerApp
{
    public class TaskManager
    {
        private List<Task> _tasks = new List<Task>();
        private int _nextId = 1;

        // Add a task to the list
        public void AddTask(string title, string description)
        {
            var task = new Task(_nextId++, title, description);
            _tasks.Add(task);
        }

        // Get all tasks
        public List<Task> GetTasks()
        {
            return _tasks;
        }

        // Edit a task by ID
        public void EditTask(int id, string newTitle, string newDescription)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.Title = newTitle;
                task.Description = newDescription;
            }
        }

        // Delete a task by ID
        public void DeleteTask(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                _tasks.Remove(task);
            }

            // Reset _nextId if all tasks are deleted
            if (!_tasks.Any())
            {
                _nextId = 1;
            }
        }

        // Mark a task as complete
        public void MarkTaskComplete(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.IsComplete = true;
            }
        }
    }

}
    