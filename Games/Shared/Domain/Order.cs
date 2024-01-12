namespace Games.Shared.Domain
{
    public class Order: BaseDomainModel
    {
        public string? TransactionType { get; set; }
        public double Price { get; set; }
        public int GameId { get; set; }
        public virtual Game? Game  { get; set; }
    }
}