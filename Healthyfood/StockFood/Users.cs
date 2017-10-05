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
    public class Users
    {
        public Dictionary<string, UserProfile> Famille;
        int _count; // cinq utilisateurs au maximum

        public Users()
        {
             Famille = new Dictionary<string, UserProfile>();
        }

        public UserProfile CreateUser(string firstName, string lastName, int age, int weigth, int heigth, bool isFemale, bool isVegetarian)
        {

            if (_count == 5) throw new ArgumentException("users must be less than five", nameof(_count));
            if (age < 0 || age > 130) throw new ArgumentException("Age must be between 0 and 130", nameof(age));
            if (firstName == null || firstName == string.Empty || string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException("The name must not be empty", nameof(firstName));
            if (lastName == null || lastName == string.Empty || string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException("The name must not be empty", nameof(lastName));
            if (Famille.ContainsKey(naming(firstName,lastName))) throw new ArgumentException("this name must be different because it already exists", nameof(lastName));
            if (heigth < 30 || heigth > 230) throw new ArgumentException("The height does not match", nameof(heigth));
            if (weigth < 0 || weigth > 250) throw new ArgumentException("The height does not match", nameof(weigth));
            UserProfile u = new UserProfile(firstName, lastName, age, weigth, heigth, isFemale, isVegetarian);
            Famille[naming(firstName, lastName)] = u;
            _count++;
            return u;
        }

        public UserProfile FindUser(string firstName, string lastName)
        {
            if (Famille.ContainsKey(naming(firstName, lastName)))
            {return Famille[naming(firstName, lastName)]; }
            else
            { throw new ArgumentException("This user does not exist", nameof(firstName)); }
        }

        public void RemoveUser(string firstName, string LastName)
        {
            if (Famille.ContainsKey(naming(firstName, LastName)))
            {
                Famille.Remove(naming(firstName, LastName));
                _count--;
            }
            else throw new ArgumentException("This user does not exist", nameof(firstName));
        }

        public void modify_firstname (UserProfile u, string firstname)
        {
            if (firstname == null || firstname == string.Empty || string.IsNullOrWhiteSpace(firstname)) throw new ArgumentException("The name must not be empty", nameof(firstname));
            else
            {
                u.FirstName = firstname;
            }

        }

        public void modify_lastname(UserProfile u, string lastname)
        {
            if (lastname == null || lastname == string.Empty || string.IsNullOrWhiteSpace(lastname)) throw new ArgumentException("The name must not be empty", nameof(lastname));
            else
            {
                u.LastName = lastname;
            }

        }

        public void modify_age (UserProfile u, int age)
        {
            if (age < 0 || age > 130) throw new ArgumentException("Age must be between 0 and 130", nameof(age));
            u.Age = age;
        }

        public void modify_weigth (UserProfile u, int weigth)
        {
            if (weigth < 0 || weigth > 250) throw new ArgumentException("The height does not match", nameof(weigth));
            u.Weight = weigth;
        }

        public void modify_heigth(UserProfile u, int heigth)
        {
            if (heigth< 30 || heigth > 230) throw new ArgumentException("The height does not match", nameof(heigth));
            u.Height = heigth;
        }

        public void modify_isfemale (UserProfile u, bool isfemale)
        {
            u.IsFemale = isfemale;
        }

        public void modify_isvegetarian(UserProfile u, bool isvegetarian)
        {
            u.IsVegetarian = isvegetarian;
        }
        public string naming (string firstName, string LastName)
        { return (firstName + " " + LastName); }

        public ICollection<UserProfile> IUtilisateur
        {
            get { return Famille.Values; }
        }
    }
}
