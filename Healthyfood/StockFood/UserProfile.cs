using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading.Tasks;


namespace StockFood
{
    [Serializable]
    public class UserProfile
    {
        string _firstName;
        string _lastName;
        int _age;
        int _weigth;
        int _heigth;
        bool _isFemale;
        bool _isVegetarian;
        //int _imc;

        internal UserProfile(string firstName, string lastName, int age, int weigth, int heigth, bool isFemale, bool isVegetarian)
        {
            if (age < 0 || age > 130) throw new ArgumentException("Age must be between 0 and 130", nameof(age));
            if (firstName == null || firstName == string.Empty || string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException("The name must not be empty", nameof(firstName));
            if (lastName == null || lastName == string.Empty || string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException("The name must not be empty", nameof(lastName));
            if (heigth < 30 || heigth > 230) throw new ArgumentException("The height does not match", nameof(heigth));
            if (weigth < 0 || weigth > 250) throw new ArgumentException("The height does not match", nameof(weigth));
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _weigth = weigth;
            _heigth = heigth;
            _isFemale = isFemale;
            _isVegetarian = isVegetarian;
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value == null || value == string.Empty || string.IsNullOrWhiteSpace(value)) throw new ArgumentException("The name must not be empty", nameof(value));
                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value == null || value == string.Empty || string.IsNullOrWhiteSpace(value)) throw new ArgumentException("The name must not be empty", nameof(value));
                _lastName = value;
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 130) throw new ArgumentException("The age must be more than 0 and less than 130", nameof(value));
                _age = value;
            }
        }

        public int Weight
        {
            get { return _weigth; }
            set
            {
                if (value < 2 || value > 230) throw new ArgumentException("The weight must be more than 2 and less than 230", nameof(value));
                _weigth = value;
            }
        }

        public int Height
        {
            get { return _heigth; }
            set
            {
                if (value < 30 || value > 250) throw new ArgumentException("The weight must be more than 30 and less than 250", nameof(value));
                _heigth = value;
            }
        }

        public bool IsFemale
        {
            get { return _isFemale; }
            set
            {
                _isFemale = value;
            }
        }

        public bool IsVegetarian
        {
            get { return _isVegetarian; }
            set
            {
                _isVegetarian = value;
            }
        }

        public int Imc
        {
        
            get
            { 
                double w = Convert.ToDouble(_weigth);
                double h = Convert.ToDouble(_heigth);
                h = (h / 100)*(h/100);
                int imc = Convert.ToInt32(w / h);
                return imc;
            }
        }
    }
}
