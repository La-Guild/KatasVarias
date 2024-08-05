

namespace SmartFridget
{
    internal class Fridge
    {
        private AddedItem addedItem;

        public static Fridge Empty => new Fridge();

        internal static bool IsExpired(DateTime currentDate, DateTime itemExpiration)
        {
            return currentDate.Day >= itemExpiration.Day;
        }

        internal string ASDfasfd(DateTime currentDate)
        {
            if (this.addedItem is not null)
            {
                if (IsExpired(currentDate, this.addedItem.Expiration))
                    return "EXPIRED: Lechuga";

                return "Tomate: 0 day(s) remaining";
            }

            return "";
        }

        internal void SADfasdf(AddedItem addedItem)
        {
            this.addedItem = addedItem;
        }
    }
}