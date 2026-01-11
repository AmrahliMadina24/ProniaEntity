namespace ProniaAdmin.Abstraction
{
    public interface IBasketService
    {
        public Task<List<BasketItem>> GetBasketItemsAsync();
    }
}
