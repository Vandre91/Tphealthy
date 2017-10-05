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

    public class TCreateRecipe

    {
        [Test]
        public void AddHealthyrecipe_with_correct_name()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            string des = "descritption";
            Assert.Throws<NullReferenceException>(() => All.AddHealthyrecipe(null, recipes, des));
            Assert.Throws<NullReferenceException>(() => All.AddHealthyrecipe(" \t\r\n", recipes, "description"));
            Assert.Throws<NullReferenceException>(() => All.AddHealthyrecipe(" ", recipes, "description"));
            Assert.Throws<NullReferenceException>(() => All.AddHealthyrecipe("", recipes, "description"));
            Recipe r = All.AddHealthyrecipe("steak fritte", recipes, des);
            Assert.That(r.Name, Is.EqualTo("steak fritte"));

        }

        [Test]
        public void AddYourrecipe_with_correct_name()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            string des = "descritption";
            Assert.Throws<NullReferenceException>(() => All.AddYourrecipe(null, recipes, des));
            Assert.Throws<NullReferenceException>(() => All.AddYourrecipe(" \t\r\n", recipes, "description"));
            Assert.Throws<NullReferenceException>(() => All.AddYourrecipe(" ", recipes, "description"));
            Assert.Throws<NullReferenceException>(() => All.AddYourrecipe("", recipes, "description"));
            Recipe r = All.AddYourrecipe("steak fritte", recipes, des);
            Assert.That(r.Name, Is.EqualTo("steak fritte"));

        }
        [Test]
        public void AddWorldrecipe_with_correct_name()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            string des = "descritption";
            Assert.Throws<NullReferenceException>(() => All.AddWorldrecipe(null, recipes, des));
            Assert.Throws<NullReferenceException>(() => All.AddWorldrecipe(" \t\r\n", recipes, "description"));
            Assert.Throws<NullReferenceException>(() => All.AddWorldrecipe(" ", recipes, "description"));
            Assert.Throws<NullReferenceException>(() => All.AddWorldrecipe("", recipes, "description"));
            Recipe r = All.AddWorldrecipe("steak fritte", recipes, des);
            Assert.That(r.Name, Is.EqualTo("steak fritte"));

        }

        [Test]
        public void AddHealthyrecipe_with_correct_list()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            List<Ingredient> recipes1 = new List<Ingredient>();
            string des = "descritption";
            Assert.Throws<ArgumentException>(() => All.AddHealthyrecipe("steak fritte", recipes1, des));
            Recipe r = All.AddHealthyrecipe("steak fritte", recipes, des);
            Assert.That(r._recette, Is.EqualTo(recipes));
        }

        [Test]
        public void AddYourRecipe_with_correct_list()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            List<Ingredient> recipes1 = new List<Ingredient>();
            string des = "descritption";
            Assert.Throws<ArgumentException>(() => All.AddYourrecipe("steak fritte", recipes1, des));
            Recipe r = All.AddYourrecipe("steak fritte", recipes, des);
            Assert.That(r._recette, Is.EqualTo(recipes));
        }

        [Test]
        public void AddWorldRecipe_with_correct_list()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            List<Ingredient> recipes1 = new List<Ingredient>();
            string des = "descritption";
            Assert.Throws<ArgumentException>(() => All.AddWorldrecipe("steak fritte", recipes1, des));
            Recipe r = All.AddWorldrecipe("steak fritte", recipes, des);
            Assert.That(r._recette, Is.EqualTo(recipes));
        }

        [Test]
        public void test_description()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            string des = "descritption";
            string des1 = null;
            Assert.Throws<ArgumentException>(() => All.AddWorldrecipe("steak fritte", recipes, des1));
            Recipe r = All.AddWorldrecipe("steak fritte", recipes, des);
            Assert.That(r.Describe, Is.EqualTo(des));

            Assert.Throws<ArgumentException>(() => All.AddYourrecipe("steak fritte", recipes, des1));
            Recipe r1 = All.AddYourrecipe("steak fritte", recipes, des);
            Assert.That(r1.Describe, Is.EqualTo(des));

            Assert.Throws<ArgumentException>(() => All.AddHealthyrecipe("steak fritte", recipes, des1));
            Recipe r2 = All.AddHealthyrecipe("steak fritte", recipes, des);
            Assert.That(r2.Describe, Is.EqualTo(des));
        }

    }
}
