using NovikovWPFLibraryApp.Infrastructure.Commands;
using NovikovWPFLibraryApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace NovikovWPFLibraryApp.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Library App";

        public string Title
        {
            get { return _Title; }
            set
            {
                Set(ref _Title, value);
            }
        }

        private string _Status = "Ready";

        public string Status
        {
            get { return _Status; }
            set
            {
                Set(ref _Status, value);
            }
        }

        #region commands
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object obj)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseApplicationCommandExecuted(object obj)
        {
            return true;
        }
        #endregion

        public MainWindowViewModel()
        {
            #region commands
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecuted);
            #endregion
        }

    }
}
