namespace Ansien.Lab
{
    class Media : Item
    {
        public string Setting(string key)
        {
            return $"{Settings[key]}";
        }
    }
}
