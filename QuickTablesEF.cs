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
Severity	Code	Description	Project	File	Line	Suppression State	Details
Error	CS0411	The type arguments for method 'TypeInference.CreateQuickTable_0_CaptureParameters<TGridItem>(IQueryable<TGridItem>, out IQueryable<TGridItem>, PaginationState, out PaginationState, string, out string)' cannot be inferred from the usage. Try specifying the type arguments explicitly.	Tabler.Docs	\\ad-its.credit-agricole.fr\Amundi_Boston\Homedirs\buonomo\@Config\Desktop\ILS Application\ILS-Application-V1\docs\Tabler.Docs\Microsoft.NET.Sdk.Razor.SourceGenerators\Microsoft.NET.Sdk.Razor.SourceGenerators.RazorSourceGenerator\Components_QuickTables_QuickTablesEF_razor.g.cs	90	Active	
Error	CS0103	The name 'DbContextFactory' does not exist in the current context	Tabler.Docs	\\ad-its.credit-agricole.fr\Amundi_Boston\Homedirs\buonomo\@Config\Desktop\ILS Application\ILS-Application-V1\docs\Tabler.Docs\Components\QuickTables\QuickTablesEF.razor	46	Active	
