using Microsoft.AspNetCore.Components;

namespace BlazorAppWasm
{
    public class BlazorRocksBase2: ComponentBase
    {
        [Inject]
        private ILogger<BlazorRocksBase2> Logger { get; set; } = default!;

        public string BlazorRocksText { get; set; } = "Blazor rocks the browser!";

        //protected override void OnInitialized() =>
        //    Logger.LogInformation("Initialization code of BlazorRocksBase2 executed!");

        protected override void OnInitialized()
        {
            BlazorRocksText = BlazorRocksText.ToUpper();
            Logger.LogInformation("Initialization code of BlazorRocksBase2 executed!");
        }

    }
}
