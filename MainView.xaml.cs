using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Controls;
using TaskManager.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView :TabbedPage
    {
        public MainView()
        {
            InitializeComponent();
            this.Children.Add(new TasksView() { Title = "New", Icon = "new_task.png" });
            this.Children.Add(new TasksView() { Title = "InProgress", Icon = "in_progress.png" });
            this.Children.Add(new TasksView() { Title = "Completed", Icon = "completed.png" });
        }

        protected override void OnCurrentPageChanged()
        {

            TasksViewModel res = (TasksViewModel)this.CurrentPage.BindingContext;
            res.PageChanged(this.CurrentPage.Title);
            //res.BindingContext
            //res.Title = "Task Manager";
            base.OnCurrentPageChanged();
        }
    }
}