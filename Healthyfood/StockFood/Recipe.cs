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
    public class Recipe
    {
        public List<Ingredient> _recette;
        string _name;
        string  _describe;

        public Recipe(string name,List<Ingredient> ing,string describe)
        {
            _name = name;
            _recette = new List<Ingredient>(ing);
            _describe = describe;

        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Describe
        {
            get { return _describe; }
            set { _describe = value; }
        }

        public IList<Ingredient> IRecipe
        {
            get { return _recette; }
        }
        
    }

}
