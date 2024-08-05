namespace SmartFridget
{
    internal class Fridge
    {
        private AddedItem addedItem;
        private OpenedFridge opened;

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
                return this.RenderItem(currentDate, this.addedItem);
            }

            return "";
        }

        private string RenderItem(DateTime currentDate, AddedItem addedItem)
        {
            if (IsExpired(currentDate, addedItem.Expiration))
                return "EXPIRED: Lechuga";

            return $"{addedItem.Name}: " +
                DaysUntilExpiration(currentDate, this.ExpirationOf(addedItem)) +
                $" day(s) remaining";
        }

        private DateTime ExpirationOf(AddedItem addedItem)
        {
            if (this.opened is not null)
                return addedItem.Expiration - TimeSpan.FromHours(1);

            return addedItem.Expiration;
        }

        internal void SADfasdf(AddedItem addedItem)
        {
            this.addedItem = addedItem;
        }

        internal void Open()
        {
            this.opened = new OpenedFridge();
        }
    }
}