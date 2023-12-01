using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using static Trigger.ViewModels.TaskViewModel;

namespace Trigger.ViewModels
{
    public class TaskViewModel : BaseViewModel
    {
        private ObservableCollection<Models.Task> _tasks;
        private string _title;
        private string _description;
        private string _status;

        public ObservableCollection<Models.Task> Tasks
        {
            get => _tasks;
            set
            {
                _tasks = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged();
            }
        }

        public ICommand Save => new Command(ExecuteSave);
        public ICommand Get => new Command(ExecuteGet);

        private void ExecuteSave()
        {
            // Implementa la lógica para guardar la tarea
            var newTask = new Models.Task
            {
                Title = Title,
                Description = Description,
                Status = Status
            };

            Tasks.Add(newTask);

            // Limpia los campos después de guardar
            Title = string.Empty;
            Description = string.Empty;
            Status = string.Empty;
        }

        private void ExecuteGet()
        {
            // Implementa la lógica para obtener las tareas (si es necesario)
        }
    //    public class TaskViewModel
    //{


    //    string title;
    //    public string Title
    //    {
    //        get { return title; }
    //        set
    //        {
    //            if (title != value)
    //            {
    //                title = value;
    //                OnPropertyChanged();
    //            }
    //        }
    //    }

        //public ObservableCollection<Models.Task> Tasks { get; set; }

        //public TaskViewModel()
        //{
        //    Tasks = new ObservableCollection<Models.Task>();
        //}

        //public void InsertTask(Models.Task newTask)
        //{
        //    Tasks.Add(newTask);
        //}

        //public ObservableCollection<Models.Task> GetTasks()
        //{
        //    return Tasks;
        //}
        //public List<string> MuchosTask { get; set; }
    }
}




