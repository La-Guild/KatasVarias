

namespace SmartFridget
{
    internal class Fridge
    {
        private AddedItem addedItem;

        public static Fridge Empty => new Fridge();

        internal string ASDfasfd()
        {
            if (addedItem is not null)
            {
                return "dfsdf";
            }

            return "";
        }

        internal void SADfasdf(AddedItem addedItem)
        {
            this.addedItem = addedItem;
        }
    }
}