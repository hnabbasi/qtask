using System;
using System.Collections.Generic;
using System.Diagnostics;
using MvvmHelpers;
using Prism.Commands;
using QTask.Models;

namespace QTask.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Title = "My Tasks";
            CompleteCommand = new DelegateCommand(OnCompleteTapped);
            GetTasks();
        }

        public List<TaskItem> Tasks { get; set; }
        public DelegateCommand CompleteCommand { get; }

        private void OnCompleteTapped()
        {
            Debug.WriteLine("Dairy completed");
        }

        private void GetTasks()
        {
            Tasks = new List<TaskItem>
            {
                new TaskItem { Id = Guid.NewGuid(), Title = "Keep social distance" },
                new TaskItem { Id = Guid.NewGuid(), Title = "Drink water" },
                new TaskItem { Id = Guid.NewGuid(), Title = "Wash hands regularly" },
                new TaskItem { Id = Guid.NewGuid(), Title = "Meditate" },
                new TaskItem { Id = Guid.NewGuid(), Title = "Call family and checkup" },
                new TaskItem { Id = Guid.NewGuid(), Title = "Read books" }
            };
        }
    }
}
