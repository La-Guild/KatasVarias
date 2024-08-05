
namespace SmartFridget
{
    internal class AddedItem
    {
        private string name;
        private DateTime expiration;

        public AddedItem(string name, DateTime expiration)
        {
            this.name = name;
            this.expiration = expiration;
        }
    }
}