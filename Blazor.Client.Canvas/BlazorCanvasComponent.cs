using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Blazor.Client.Canvas
{
    public class BlazorCanvasComponent : ComponentBase
    {
        [Inject] internal IJSRuntime Runtime { get; set; }
        [Parameter] protected long Width { get; set; }
        [Parameter] protected long Height { get; set; }
        protected ElementRef Canvas { get; set; }
        internal ElementRef CanvasRef => Canvas;
        public ICanvas2DContext Canvas2DContext { get => new Canvas2DContext(this); }
    }
}
