using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood
{
    [Serializable]
    public class AllMenu
    {
        Dictionary<string, Menu> _menu;

        public AllMenu()
        {
            _menu = new Dictionary<string, Menu>();
        }
        public Menu AddMenu(string name, Dictionary<string,Recipe> recipe, DateTime datef,DateTime datel)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException();
            }

            if (_menu.ContainsKey(name))
            {
                throw new ArgumentException();
            }
            if (datef == null ) throw new ArgumentException("The description is empty", nameof(datef));
            if (datel == null) throw new ArgumentException("The description is empty", nameof(datel));
            Menu m = new Menu(name, recipe, datef,datel);
            _menu.Add(name, m);
            return m;
        }
        public Menu FindMenu(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new NullReferenceException();

            if (_menu.ContainsKey(name))
            {
                Menu me = _menu[name];
                return me;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public bool RemoveMenu(Menu i)
        {
            if (i == null)
                throw new NullReferenceException();

            string name = i.Name;

            if (_menu.ContainsKey(name))
            {
                Menu m = _menu[name];
                _menu.Remove(name);

                return true;
            }
            else
            {
                return false;
            }
        }
        public ICollection<Menu> Menus
        {
            get { return _menu.Values; }
        }
    }
}
