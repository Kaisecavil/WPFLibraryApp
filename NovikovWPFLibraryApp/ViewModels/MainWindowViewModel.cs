using NovikovWPFLibraryApp.Infrastructure.Commands;
using NovikovWPFLibraryApp.Models;
using NovikovWPFLibraryApp.Repository;
using NovikovWPFLibraryApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private string _title = "Library App";

        public string Title
        {
            get { return _title; }
            set
            {
                Set(ref _title, value);
            }
        }

        private string _status = "Ready";

        public string Status
        {
            get { return _status; }
            set
            {
                Set(ref _status, value);
            }
        }

        private List<Book> _bookCollection;

        public List<Book> BookCollection
        {
            get { return _bookCollection; }
            set
            {
                Set(ref _bookCollection, value);
            }
        }

        


        public MainWindowViewModel()
        {
            GenericRepository<Book> repository = new GenericRepository<Book>(new ApplicationContext());
            var books = repository.GetAll().ToList();
            BookCollection = books;
        }
    }
}
