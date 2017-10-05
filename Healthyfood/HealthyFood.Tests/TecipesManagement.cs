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

    public class TRecipesManagement

    {
        [Test]
        public void AddHealthyrecipe_already_exists_and_find_Recipes()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            string des = "descritption";
            Recipe r = All.AddHealthyrecipe("steak fritte", recipes, des);
            Assert.Throws<ArgumentException>(() => All.AddHealthyrecipe("steak fritte", recipes, des));
        }

        [Test]
        public void FindHealthyRecipe_correctly()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            string des = "descritption";
            Recipe r = All.AddHealthyrecipe("steak fritte", recipes, des);
            Assert.Throws<NullReferenceException>(() => All.FindHealthyrecipe(""));
            Assert.Throws<NullReferenceException>(() => All.FindHealthyrecipe(null));
            Assert.Throws<NullReferenceException>(() => All.FindHealthyrecipe(" "));
            Assert.Throws<NullReferenceException>(() => All.FindHealthyrecipe(" \t\r\n"));

            Recipe r1 = All.FindHealthyrecipe("steak fritte");
            Assert.That(r1, Is.EqualTo(r));

            Assert.Throws<ArgumentException>(() => All.FindHealthyrecipe("pomme au four"));

        }

        [Test]
        public void RemoveHealthyRecipe_correctly()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            string des = "descritption";
            Recipe r = All.AddHealthyrecipe("steak fritte", recipes, des);
            Recipe r1 = All.FindHealthyrecipe("steak fritte");
            Assert.That(r1, Is.EqualTo(r));
            bool result = All.RemoveHealthyrecipe(r);
            Assert.That(result, Is.EqualTo(true));
            Assert.That(All.RemoveHealthyrecipe(r1), Is.EqualTo(false));

        }

        [Test]

        public void AddYourRecipe_already_exists_and_find_Recipes()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            string des = "descritption";
            Recipe r = All.AddYourrecipe("steak fritte", recipes, des);
            Assert.Throws<ArgumentException>(() => All.AddYourrecipe("steak fritte", recipes, des));
        }

        [Test]
        public void FindYourRecipe_correctly()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            string des = "descritption";
            Recipe r = All.AddYourrecipe("steak fritte", recipes, des);
            Assert.Throws<NullReferenceException>(() => All.FindYourrecipe(""));
            Assert.Throws<NullReferenceException>(() => All.FindYourrecipe(null));
            Assert.Throws<NullReferenceException>(() => All.FindYourrecipe(" "));
            Assert.Throws<NullReferenceException>(() => All.FindYourrecipe(" \t\r\n"));

            Recipe r1 = All.FindYourrecipe("steak fritte");
            Assert.That(r1, Is.EqualTo(r));

            Assert.Throws<ArgumentException>(() => All.FindHealthyrecipe("pomme au four"));

        }

        [Test]
        public void RemoveYourRecipe_correctly()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            string des = "descritption";
            Recipe r = All.AddYourrecipe("steak fritte", recipes, des);
            Recipe r1 = All.FindYourrecipe("steak fritte");
            Assert.That(r1, Is.EqualTo(r));
            bool result = All.RemoveYourrecipe(r);
            Assert.That(result, Is.EqualTo(true));
            Assert.That(All.RemoveYourrecipe(r1), Is.EqualTo(false));

        }

        [Test]

        public void AddWorldRecipe_already_exists_and_find_Recipes()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            string des = "descritption";
            Recipe r = All.AddWorldrecipe("steak fritte", recipes, des);
            Assert.Throws<ArgumentException>(() => All.AddWorldrecipe("steak fritte", recipes, des));
        }

        [Test]
        public void FindWorldRecipe_correctly()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            string des = "descritption";
            Recipe r = All.AddWorldrecipe("steak fritte", recipes, des);
            Assert.Throws<NullReferenceException>(() => All.FindWorldrecipe(""));
            Assert.Throws<NullReferenceException>(() => All.FindWorldrecipe(null));
            Assert.Throws<NullReferenceException>(() => All.FindWorldrecipe(" "));
            Assert.Throws<NullReferenceException>(() => All.FindWorldrecipe(" \t\r\n"));

            Recipe r1 = All.FindWorldrecipe("steak fritte");
            Assert.That(r1, Is.EqualTo(r));

            Assert.Throws<ArgumentException>(() => All.FindWorldrecipe("pomme au four"));

        }

        [Test]
        public void RemoveWorldRecipe_correctly()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            string des = "descritption";
            Recipe r = All.AddWorldrecipe("steak fritte", recipes, des);
            Recipe r1 = All.FindWorldrecipe("steak fritte");
            Assert.That(r1, Is.EqualTo(r));
            bool result = All.RemoveWorldrecipe(r);
            Assert.That(result, Is.EqualTo(true));
            Assert.That(All.RemoveWorldrecipe(r1), Is.EqualTo(false));

        }
    }
}