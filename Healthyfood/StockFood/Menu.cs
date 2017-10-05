using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood
{
    [Serializable]
    public class Menu
    {
        string _name;
        Dictionary<string, Recipe> _recipes;
        DateTime _datefirst;
        DateTime _datelast;

        public Menu(string nom,Dictionary<string,Recipe> recette,DateTime datef,DateTime datel )
        {
            _name = nom;
            _recipes = new Dictionary<string, Recipe>(recette);
            _datefirst = datef;
            _datelast = datel;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public DateTime Datefirst
        {
            get { return _datefirst; }
            set { _datefirst = value; }
        }
        public DateTime Datelast
        {
            get { return _datelast; }
            set { _datelast = value; }
        }
        public ICollection<Recipe> IMenu
        {
            get { return _recipes.Values; }

        }
    }
}
