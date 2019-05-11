using System.Collections.Generic;

namespace Ansien.Lab
{
    class Item
    {
        public object this[string key]
        {
            get { return Settings[key]; }
            set { Settings[key] = value; }
        }

        public int Id;

        public Dictionary<string, object> Settings = new Dictionary<string, object>();
    }
}
