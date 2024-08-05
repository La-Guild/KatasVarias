namespace SmartFridget
{
    internal class Fridge
    {
        private AddedItem addedItem;
        private OpenedFridge opened;
        private DateTime today;

        public static Fridge Empty => new Fridge();

        internal static bool IsExpired(DateTime currentDate, DateTime itemExpiration)
        {
            return currentDate.Day >= itemExpiration.Day;
        }

        public void AtDay(DateTime when)
        {
            this.today = when;
        }

        internal static int DaysUntilExpiration(
            DateTime currentDate,
            DateTime itemExpiration)
        {
            return itemExpiration.Day - currentDate.Day - 1;
        }

        internal string DisplayContents(DateTime currentDate)
        {
            AtDay(currentDate);

            return DisplayContents2();
        }

        private string DisplayContents2()
        {
            if (this.addedItem is not null)
            {
                return this.RenderItem(today, this.addedItem);
            }

            return "";
        }

        private string RenderItem(DateTime currentDate, AddedItem addedItem)
        {
            if (IsExpired(currentDate, this.ExpirationOf(addedItem)))
                return $"EXPIRED: {addedItem.Name}";

            return $"{addedItem.Name}: " +
                DaysUntilExpiration(currentDate, this.ExpirationOf(addedItem)) +
                $" day(s) remaining";
        }

        private DateTime ExpirationOf(AddedItem addedItem)
        {
            if (this.opened is not null)
                return addedItem.WasInsideFridgeAt(this.opened.When)
                    ? addedItem.Expiration - TimeSpan.FromHours(1)
                    : addedItem.Expiration;

            return addedItem.Expiration;
        }

        internal void SADfasdf(AddedItem addedItem)
        {
            this.addedItem = addedItem;
        }

        internal void Open()
        {
            this.opened = new OpenedFridge(When: today);
        }
    }
}