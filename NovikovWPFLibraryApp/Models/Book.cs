using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovikovWPFLibraryApp.Models
{
    internal class Book
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _secondName;

        public string SecondName
        {
            get { return _secondName; }
            set { _secondName = value; }
        }

        private string _surName;

        public string SurName
        {
            get { return _surName; }
            set { _surName = value; }
        }

        private string _birthDate;

        public string BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        private string _bookName;

        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }

        private int _bookYear;

        public int BookYear
        {
            get { return _bookYear; }
            set { _bookYear = value; }
        }

        public Book(string firstName, string secondName, string surName, string birthDate, string bookName, int bookYear)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            SecondName = secondName ?? throw new ArgumentNullException(nameof(secondName));
            SurName = surName ?? throw new ArgumentNullException(nameof(surName));
            BirthDate = birthDate ?? throw new ArgumentNullException(nameof(birthDate));
            BookName = bookName ?? throw new ArgumentNullException(nameof(bookName));
            BookYear = bookYear;
        }
    }
}
