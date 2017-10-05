using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood
{
    [Serializable]
    public class Ingredient
    {
        public static List<string> _Category = new List<string> {"viande", "poisson", "crustace", "dessert_sucrerie", "boisson", "volaille", "legume", "fruit", "produit_laitier", "matiere_grasse", "feculent", "boulangerie", "herbe_plante" };

        string _name;
        public  string _category;
        DateTime _expiration_date;
        int _balance;


        public Ingredient (string category, string name, int balance, DateTime expiration_date)
        {
            _category = category;
            _name = name;
            _balance = balance;
            _expiration_date = expiration_date;
        }

        public string Category ()
        {
           return _category;
        }

        public string Category1
        { get { return _category; } }
       

        public DateTime Expiration_Date
        {
            get { return _expiration_date; }
            set { _expiration_date = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        
    }
}
