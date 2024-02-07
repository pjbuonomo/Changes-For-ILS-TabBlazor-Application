@using Microsoft.EntityFrameworkCore
@using Tabler.Docs.Data // Adjust this to your actual namespace where ApplicationDbContext and MarketQuote are located
@inject IDbContextFactory<ApplicationDbContext> DbContextFactory

<div class="card">
    <QuickTable Items="marketQuotes" Pagination="@pagination" Class="quick-table-example">
        <PropertyColumn Property="@(mq => mq.QuoteDate)" Title="Date" Sortable="true"/>
        <PropertyColumn Property="@(mq => mq.Broker)" Title="Broker" Sortable="true"/>
        <PropertyColumn Property="@(mq => mq.CUSIP)" Title="CUSIP" Sortable="true"/>
        <PropertyColumn Property="@(mq => mq.Bond)" Title="Bond" Sortable="true"/>
        <PropertyColumn Property="@(mq => mq.Size)" Title="Size" Sortable="true"/>
        <PropertyColumn Property="@(mq => mq.Actions)" Title="Actions" Sortable="true"/>
        <PropertyColumn Property="@(mq => mq.Price)" Title="Price" Sortable="true"/>
    </QuickTable>
    <Paginator Value="@pagination"/>
</div>

@code {
    private PaginationState pagination = new PaginationState { ItemsPerPage = 15 };
    private List<MarketQuote>? marketQuotes;

    protected override async Task OnInitializedAsync()
    {
        var dbContext = DbContextFactory.CreateDbContext();
        marketQuotes = await dbContext.MarketQuotes.ToListAsync();
    }
}
