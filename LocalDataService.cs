public class LocalDataService : IDataService
{
    private readonly ApplicationDbContext _dbContext;

    public LocalDataService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<MarketQuote> MarketQuotes => _dbContext.MarketQuotes;

    public async Task<GridItemsProviderResult<MarketQuote>> GetMarketQuotesAsync(
        int startIndex, 
        int? count, 
        string sortBy,
        bool sortAscending, 
        CancellationToken cancellationToken)
    {
        var query = _dbContext.MarketQuotes.AsQueryable();

        // Example sorting (adjust according to actual sortable properties)
        var ordered = sortAscending ? query.OrderBy(mq => mq.QuoteDate) : query.OrderByDescending(mq => mq.QuoteDate);

        // Apply dynamic sorting based on sortBy and sortAscending
        // This part needs to be implemented based on actual sortable properties of MarketQuote

        var result = ordered.Skip(startIndex);

        if (count.HasValue)
        {
            result = result.Take(count.Value);
        }

        return GridItemsProviderResult.From(await result.ToListAsync(cancellationToken), await ordered.CountAsync());
    }
}
