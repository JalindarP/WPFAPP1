using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.Models;
using WpfApplication1.Helper;
using System.Windows.Input;
using System.Windows;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections;

namespace WpfApplication1.ViewModels
{
    internal class StudentViewModel : INotifyPropertyChanged//, INotifyDataErrorInfo
    {
        public List<string> _classList = new List<string>();
        private ObservableCollection<Student> _studentCollecton; 

        public StudentViewModel()
        {
            _classList.Add("First");
            _classList.Add("Second");
            _classList.Add("Third");
            _classList.Add("Fourth");

            _studentCollecton = new ObservableCollection<Student>();
            Student st = new Student();
            st.FirstName = "Jalindar";
            st.LastName = "Pandharkar";
            st.Gender = Gender.Male;
            st.Standard = "Third";
            _studentCollecton.Add(st);

        }
        public event PropertyChangedEventHandler PropertyChanged;       

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        

        private string _firstName;
        public string FirstName { get { return _firstName; } set { _firstName = value; RaisePropertyChanged("FirstName"); } }

        private string _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; RaisePropertyChanged("LastName"); } }

        private Gender _gender;
        public Gender Gender { get { return _gender; } set { _gender = value; RaisePropertyChanged("Gender"); } }

        public List<string> ClassList
        {
            get { return _classList; }
            set { }
        }

        private string _standard;
        public string Standard { get { return _standard; } set { _standard = value; RaisePropertyChanged("Standard"); } }


        public ObservableCollection<Student> StudentCollection
        {
            get { return _studentCollecton; }
            set { _studentCollecton = value; }
        }
        
        public ICommand AddCommand
        {
            get
            {
                return new MyCommand(AddCommandExecute, AddCommandCanExecute);
            }
            set { }
        }

        private bool AddCommandCanExecute(object parameter)
        {
            return true;
        }

        private void AddCommandExecute(object parameter)
        {
            Student st = new Student();
            st.FirstName = FirstName;
            st.LastName = LastName;
            st.Gender = Gender;
            st.Standard = Standard;
            _studentCollecton.Add(st);            
            //MessageBox.Show("Added");
        }

        public ICommand UpdateCommand
        {
            get
            {
                return new MyCommand(UpdateCommandExecute, UpdateCommandCanExecute);
            }
            set { }
        }

        private bool UpdateCommandCanExecute(object parameter)
        {
            return true;
        }

        private void UpdateCommandExecute(object parameter)
        { 
            MessageBox.Show("Not Implemented");
        }

        public ICommand DeleteCommand
        {
            get
            {
                return new MyCommand(DeleteCommandExecute, DeleteCommandCanExecute);
            }
            set { }
        }

        private bool DeleteCommandCanExecute(object parameter)
        {
            return true;
        }

        private void DeleteCommandExecute(object parameter)
        {          
            MessageBox.Show("Not Implemented");
        }

        private Student _student;
        public Student SelectedStudent
        {
            get { return _student; }
            set {
                _student = value;
                FirstName = _student.FirstName;
                LastName = _student.LastName;
                Gender = _student.Gender;
                Standard = _student.Standard;
            }
        }

        //public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        //public bool HasErrors
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
        //public IEnumerable GetErrors(string propertyName)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

