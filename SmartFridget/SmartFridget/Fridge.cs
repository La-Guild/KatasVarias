

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

        internal static int DaysUntilExpiration(
            DateTime currentDate,
            DateTime itemExpiration)
        {
            return itemExpiration.Day - currentDate.Day - 1;
        }

        internal string ASDfasfd(DateTime currentDate)
        {
            if (this.addedItem is not null)
            {
                return RenderItem(currentDate, this.addedItem);
            }

            return "";
        }

        private static string RenderItem(DateTime currentDate, AddedItem addedItem)
        {
            if (IsExpired(currentDate, addedItem.Expiration))
                return "EXPIRED: Lechuga";

            return $"{addedItem.Name}: " +
                DaysUntilExpiration(currentDate, addedItem.Expiration) +
                $" day(s) remaining";
        }

        internal void SADfasdf(AddedItem addedItem)
        {
            this.addedItem = addedItem;
        }
    }
}