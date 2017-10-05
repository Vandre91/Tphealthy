using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Healthyfood;
using StockFood;

namespace HealthyFoodTests
{
    [TestFixture]

    public class TCreateUsers
    {
        [Test]
        public void create_or_modify_user_with_correct_firstname()
        {
            Users users = new Users();
            Assert.Throws<ArgumentException>(() => users.CreateUser("", "ab", 10, 30, 30, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser(null, "ab", 10, 30, 30, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser(" ", "ab", 10, 30, 30, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser(" \t\r\n", "ab", 10, 30, 30, true, false));
            UserProfile u = users.CreateUser("cd", "ab", 10, 30, 30, true, false);
            Assert.That(u.FirstName, Is.EqualTo("cd"));
            Assert.That(u.LastName, Is.EqualTo("ab"));
            Assert.That(u.Age, Is.EqualTo(10));
            Assert.That(u.Weight, Is.EqualTo(30));
            Assert.That(u.Height, Is.EqualTo(30));
            Assert.That(u.IsFemale, Is.EqualTo(true));
            Assert.That(u.IsVegetarian, Is.EqualTo(false));


        }

        [Test]
        public void modify_created_users()
        {
            Users users = new Users();
            UserProfile u = users.CreateUser("cd", "ab", 10, 30, 30, true, false);
            users.modify_firstname(u, "dc");
            Assert.That(u.FirstName, Is.EqualTo("dc"));
            users.modify_lastname(u, "dc");
            Assert.That(u.LastName, Is.EqualTo("dc"));
            users.modify_age(u, 40);
            Assert.That(u.Age, Is.EqualTo(40));
            users.modify_heigth(u, 120);
            Assert.That(u.Height, Is.EqualTo(120));
            users.modify_weigth(u, 200);
            Assert.That(u.Weight, Is.EqualTo(200));
            users.modify_isfemale(u, false);
            Assert.That(u.IsFemale, Is.EqualTo(false));
            users.modify_isvegetarian(u, true);
            Assert.That(u.IsVegetarian, Is.EqualTo(true));
            Assert.Throws<ArgumentException>(() => users.modify_firstname(u, ""));
            Assert.Throws<ArgumentException>(() => users.modify_firstname(u, null));
            Assert.Throws<ArgumentException>(() => users.modify_firstname(u, " "));
            Assert.Throws<ArgumentException>(() => users.modify_firstname(u, " \t\r\n"));
            Assert.Throws<ArgumentException>(() => users.modify_lastname(u, ""));
            Assert.Throws<ArgumentException>(() => users.modify_lastname(u, null));
            Assert.Throws<ArgumentException>(() => users.modify_lastname(u, " "));
            Assert.Throws<ArgumentException>(() => users.modify_lastname(u, " \t\r\n"));
            Assert.Throws<ArgumentException>(() => users.modify_age(u, -1));
            Assert.Throws<ArgumentException>(() => users.modify_age(u, 131));
            Assert.Throws<ArgumentException>(() => users.modify_heigth(u, 29));
            Assert.Throws<ArgumentException>(() => users.modify_heigth(u, 231));
            Assert.Throws<ArgumentException>(() => users.modify_weigth(u, -1));
            Assert.Throws<ArgumentException>(() => users.modify_weigth(u, 251));

        }

        [Test]
        public void create_or_modify_user_with_correct_lastname()
        {
            Users users = new Users();
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", null, 10, 30, 30, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "", 10, 30, 30, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab ", " ", 10, 30, 30, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", " \t\r\n", 10, 30, 30, true, false));
        }

        [Test]
        public void create_or_modify_user_with_correct_age()
        {
            Users users = new Users();
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", -1, 10, 10, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 129, 10, 10, true, false));

        }

        [Test]
        public void create_user_with_correct_weight()
        {
            Users users = new Users();
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 10, -1, 10, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 10, 231, 10, true, false));

        }

        [Test]
        public void create_user_with_correct_height()
        {
            Users users = new Users();
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 10, 10, 29, true, false));
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 10, 10, 251, true, false));

        }

        [Test]
        public void create_or_modify__a_user_with_a_different_name_and_first_name_of_another_user()
        {
            Users users = new Users();
            UserProfile u = users.CreateUser("ab", "cd", 10, 10, 180, false, false);
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cd", 10, 10, 180, false, false));
            UserProfile v = users.CreateUser("ab", "cde", 10, 10, 180, false, false);
            Assert.Throws<ArgumentException>(() => users.CreateUser("ab", "cde", 10, 10, 180, false, false));
            //Profil_Utilisateur w = users.CreateUser("cd", "cd", 10, 10, 180, false, false);
            //Assert.Throws<ArgumentException>(() => users.modify_firstname(w, "ab"));
        }

        [Test]
        public void create_five_users_max()
        {
            Users users = new Users();
            users.CreateUser("ab", "cd", 10, 10, 180, false, false);
            users.CreateUser("abc", "cd", 10, 10, 180, false, false);
            users.CreateUser("abd", "cd", 10, 10, 180, false, false);
            users.CreateUser("abe", "cd", 10, 10, 180, false, false);
            users.CreateUser("abf", "cd", 10, 10, 180, false, false);
            Assert.Throws<ArgumentException>(() => users.CreateUser("abg", "cd", 10, 10, 180, false, false));

        }

        [Test]
        public void find_users()
        {
            Users users = new Users();
            UserProfile u = users.CreateUser("ab", "cd", 10, 10, 180, false, false);
            users.CreateUser("abc", "cd", 10, 10, 180, false, false);
            users.CreateUser("abd", "cd", 10, 10, 180, false, false);
            Assert.Throws<ArgumentException>(() => users.FindUser("abg", "cd"));
            Assert.That(users.FindUser("ab", "cd"), Is.EqualTo(u));

        }

        [Test]
        public void remove_users()
        {
            Users users = new Users();
            users.CreateUser("ab", "cd", 10, 10, 180, false, false);
            users.CreateUser("abc", "cd", 10, 10, 180, true, false);
            users.CreateUser("abd", "cd", 10, 10, 180, false, false);
            users.RemoveUser("ab", "cd");
            Assert.Throws<ArgumentException>(() => users.FindUser("ab", "cd"));
            Assert.Throws<ArgumentException>(() => users.RemoveUser("aassb", "cd"));

        }

        [Test]
        public void modify_isfemale_and_isvegeterian()
        {
            Users users = new Users();
            UserProfile u = users.CreateUser("ab", "cd", 10, 10, 180, false, false);
            u.IsFemale = true;
            Assert.That(u.IsFemale, Is.EqualTo(true));
            u.IsVegetarian = true;
            Assert.That(u.IsVegetarian, Is.EqualTo(true));
        }

        [Test]
        public void imc()
        {
            Users users = new Users();
            UserProfile u = users.CreateUser("ab", "cd", 25, 54, 150, false, false);
            Assert.That(u.Imc, Is.EqualTo(24));

        }
    }
}
