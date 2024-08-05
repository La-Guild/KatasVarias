
namespace SmartFridget
{
    internal record AddedItem(string Name, DateTime Expiration, DateTime AddedAt = default)
    {
        public bool WasInsideFridgeAt(DateTime when)
        {
            return this.AddedAt <= when;
        }
    }
}