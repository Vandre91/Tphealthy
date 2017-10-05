using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood
{
    [Serializable]
    public class AllRecipe
    {
        public Dictionary<string, Recipe> _healthyrecipe;
        public Dictionary<string, Recipe> _yourrecipe;
        public Dictionary<string, Recipe> _worldrecipe;

        public AllRecipe()
        {
            _healthyrecipe = new Dictionary<string, Recipe>();
            _yourrecipe = new Dictionary<string, Recipe>();
            _worldrecipe = new Dictionary<string, Recipe>();
        }

        public Recipe AddHealthyrecipe(string name,List<Ingredient> ing,string describe)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException();
            }

            if (_healthyrecipe.ContainsKey(name))
            {
                throw new ArgumentException();
            }

            if (ing.Count == 0) throw new ArgumentException("This list is null", nameof(ing));
            if (describe == null || describe == string.Empty) throw new ArgumentException("The description is empty", nameof(describe));
            Recipe c = new Recipe(name,ing,describe);
            _healthyrecipe.Add(name, c);
            return c;
        }
        public Recipe FindHealthyrecipe(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new NullReferenceException();

            if (_healthyrecipe.ContainsKey(name))
            {
                Recipe rec = _healthyrecipe[name];
                return rec;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public bool RemoveHealthyrecipe(Recipe i)
        {
            if (i == null)
                throw new NullReferenceException();

            string name = i.Name;

            if (_healthyrecipe.ContainsKey(name))
            {
                Recipe p = _healthyrecipe[name];
                _healthyrecipe.Remove(name);

                return true;
            }
            else
            {
                return false;
            }
        }
        public ICollection<Recipe> Healthyrecipe
        {
            get { return _healthyrecipe.Values; }
        }
        public Recipe AddYourrecipe(string name, List<Ingredient> ing, string describe)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException();
            }

            if (_yourrecipe.ContainsKey(name))
            {
                throw new ArgumentException();
            }

            if (ing.Count == 0) throw new ArgumentException("This list is null", nameof(ing));

            if (describe == null || describe == string.Empty) throw new ArgumentException("The description is empty", nameof(describe));

            Recipe c = new Recipe(name, ing, describe);
            _yourrecipe.Add(name, c);
            return c;
        }
        public Recipe FindYourrecipe(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new NullReferenceException();

            if (_yourrecipe.ContainsKey(name))
            {
                Recipe rec = _yourrecipe[name];
                return rec;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public bool RemoveYourrecipe(Recipe i)
        {
            if (i == null)
                throw new NullReferenceException();

            string name = i.Name;

            if (_yourrecipe.ContainsKey(name))
            {
                Recipe p = _yourrecipe[name];
                _yourrecipe.Remove(name);

                return true;
            }
            else
            {
                return false;
            }
        }
        public ICollection<Recipe> Yourrecipe
        {
            get { return _yourrecipe.Values; }
        }

        public Recipe AddWorldrecipe(string name, List<Ingredient> ing, string describe)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException();
            }

            if (_worldrecipe.ContainsKey(name))
            {
                throw new ArgumentException();
            }

            if (describe == null || describe == string.Empty) throw new ArgumentException("The description is empty", nameof(describe));

            if (ing.Count == 0) throw new ArgumentException("This list is null", nameof(ing));

            Recipe c = new Recipe(name, ing, describe);
            _worldrecipe.Add(name, c);
            return c;
        }
        public Recipe FindWorldrecipe(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new NullReferenceException();

            if (_worldrecipe.ContainsKey(name))
            {
                Recipe rec = _worldrecipe[name];
                return rec;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public bool RemoveWorldrecipe(Recipe i)
        {
            if (i == null)
                throw new NullReferenceException();

            string name = i.Name;

            if (_worldrecipe.ContainsKey(name))
            {
                Recipe p = _worldrecipe[name];
                _worldrecipe.Remove(name);

                return true;
            }
            else
            {
                return false;
            }
        }
        public ICollection<Recipe> Worldrecipe
        {
            get { return _worldrecipe.Values; }
        }

        
    }
}
