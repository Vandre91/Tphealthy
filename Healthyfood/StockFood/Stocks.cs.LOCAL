using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockFood
{
    [Serializable]
    public class Stocks
    {
        public Dictionary<string, Ingredient> _stock;

        public Stocks()
        {
            _stock = new Dictionary<string, Ingredient>();
        }

        public static string naming(Ingredient ingred)
        {
            return ((ingred.Name) + " " + Convert.ToString(ingred.Expiration_Date));
        }

        public Ingredient AddIngredient(string category, string name, int balance, DateTime expiration_date)
        {

            if (category == null || category == string.Empty || string.IsNullOrWhiteSpace(category)) throw new ArgumentException("The name must not be empty", nameof(category));
            if (name == null || name == string.Empty || string.IsNullOrWhiteSpace(name)) throw new ArgumentException("The name must not be empty", nameof(name));
            if (!(Ingredient._Category.Contains(category))) throw new ArgumentException("This category does not exist", nameof(category));
            if (expiration_date < DateTime.Today) throw new ArgumentException("This ingredient is obsolete", nameof(expiration_date));
            if (balance <= 0) throw new ArgumentException("The balance must be more than 0", nameof(balance));
            Ingredient ingred = new Ingredient(category, name, balance, expiration_date);
            if (_stock.ContainsKey(naming(ingred)))
            {
                int bal = _stock[name + " " + Convert.ToString(expiration_date)].Balance + balance;
                RemoveIngredient(name, expiration_date);
                Ingredient i = AddIngredient(category, name, bal, expiration_date);
                return i;
            }
            else
            {
                _stock[naming(ingred)] = ingred;

                return ingred;
            }

        }

        public void RemoveIngredient(string name, DateTime expiration_date)

        {
            if (_stock.ContainsKey(name + " " + Convert.ToString(expiration_date)))
            {
                _stock.Remove(name + " " + Convert.ToString(expiration_date));
            }
            else
            {
                throw new ArgumentException("This ingredient does not exist", nameof(name));
            }

        }

        public Ingredient ReduceIngredient(string name, int balance, DateTime expiration_date)
        {
            if (balance <= 0) throw new ArgumentException("The balance must be more than 0", nameof(balance));
            if (_stock.ContainsKey(name + " " + Convert.ToString(expiration_date)))
            {
                if (balance > _stock[name + " " + Convert.ToString(expiration_date)].Balance)
                {
                    throw new ArgumentException(" ");
                }
                else
                {
                    int bal = _stock[name + " " + Convert.ToString(expiration_date)].Balance - balance;
                    string category = _stock[name + " " + Convert.ToString(expiration_date)].Category1;
                    RemoveIngredient(name, expiration_date);
                    Ingredient i = AddIngredient(category, name, bal, expiration_date);
                    if (bal == 0) RemoveIngredient(name, expiration_date);
                    return i;

                }
            }
            else
            {
                throw new ArgumentException("this ingredient does not exist", nameof(name));
            }
        }

        public ICollection<Ingredient> IStock
        {
            get { return _stock.Values; }
        }
        public void CheckExpirationDate(Stocks ing)
        {

            Dictionary<string, Ingredient> myDic = new Dictionary<string, Ingredient>();
            DateTime d = new DateTime();

            foreach (KeyValuePair<string, Ingredient> ingre in _stock)
           
                if (d >= DateTime.Today)
                {
                     MessageBox.Show ("The product is out-of-date because the expiry date is reached!");
                }
                else { }
            }

        }
    }

     
    
   

