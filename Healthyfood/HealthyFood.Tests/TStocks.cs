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

    public class TStocks
    {
        [Test]
        public void Add_ingredient_with_correct_category()
        {
            Stocks stocks = new Stocks();
            DateTime date = new DateTime(2017, 10, 10);
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande humaine", "lait", 100, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient(" ", "lait", 100, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient(null, "lait", 100, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("", "lait", 100, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient(" \t\r\n", "lait", 100, date));
            Ingredient i = stocks.AddIngredient("viande", "lait", 100, date);
            Assert.That(i.Category, Is.EqualTo("viande"));
        }

        [Test]
        public void Add_ingredient_with_correct_name()
        {
            Stocks stocks = new Stocks();
            DateTime date = new DateTime(2017, 10, 10);
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande", "", 100, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande", " ", 100, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande", null, 100, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande", " \t\r\n", 100, date));
            Ingredient i = stocks.AddIngredient("viande", "Steak de boeuf", 100, date);
            Assert.That(i.Name, Is.EqualTo("Steak de boeuf"));

        }

        [Test]
        public void Add_ingredient_with_correct_balance_and_expiration_date()
        {
            Stocks stocks = new Stocks();
            DateTime date = new DateTime(2017, 10, 10);
            DateTime date1 = new DateTime(2008, 10, 10);
            DateTime date2 = DateTime.Today;
            DateTime date3 = new DateTime(2018, 10, 10);
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande", "Steak de boeuf", 0, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande", "Steak de boeuf", -10, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande", "Steak de boeuf", 100, date1));
            Ingredient i = stocks.AddIngredient("viande", "Steak de boeuf", 100, date2);
            Assert.That(i.Expiration_Date, Is.EqualTo(DateTime.Today));
            Assert.That(i.Balance, Is.EqualTo(100));
            Ingredient u = stocks.AddIngredient("viande", "Steak de boeuf", 100, date3);
            Assert.That(u.Expiration_Date, Is.EqualTo(date3));

        }

        [Test]
        public void Remove_ingredient_correctly()
        {
            Stocks stocks = new Stocks();
            DateTime date = new DateTime(2017, 10, 10);
            DateTime date1 = new DateTime(2018, 10, 10);
            Ingredient i = stocks.AddIngredient("viande", "Steak de boeuf", 100, date);
            Ingredient u = new Ingredient("viande", "cote de boeuf", 100, date);
            Assert.Throws<ArgumentException>(() => stocks.RemoveIngredient("cote de boeuf", date));
            Assert.Throws<ArgumentException>(() => stocks.RemoveIngredient("Steak de boeuf", date1));
            stocks.RemoveIngredient("Steak de boeuf", date);
            Assert.Throws<ArgumentException>(() => stocks.RemoveIngredient("Steak de boeuf", date));
            Assert.Throws<ArgumentException>(() => stocks.RemoveIngredient("Steak de chien", date));

        }

        [Test]
        public void Add_ingredient_which_already_exist ()
        {
            Stocks stocks = new Stocks();
            DateTime date = new DateTime(2017, 10, 10);
            Ingredient i = stocks.AddIngredient("viande", "Steak de boeuf", 100, date);
            i= stocks.AddIngredient("viande", "Steak de boeuf", 150, date);
            Assert.That(i.Balance, Is.EqualTo(250));
        }

        [Test]
        public void Reduce_ingredient_correctly()
        {
            Stocks stocks = new Stocks();
            DateTime date = new DateTime(2017, 10, 10);
            Ingredient i = stocks.AddIngredient("viande", "Steak de boeuf", 100, date);
            Ingredient u = stocks.AddIngredient("viande", "cote de boeuf", 100, date);
            Assert.Throws<ArgumentException>(() => stocks.ReduceIngredient("Steak de boeuf",200, date));
            Assert.Throws<ArgumentException>(() => stocks.ReduceIngredient("Steak de chat", 200, date));
            Assert.Throws<ArgumentException>(() => stocks.ReduceIngredient("Steak de boeuf", -1, date));
            Assert.That(i.Balance, Is.EqualTo(100));
            i= stocks.ReduceIngredient("Steak de boeuf", 50, date);
            Assert.That(i.Balance, Is.EqualTo(50));
        }

    }
}
 