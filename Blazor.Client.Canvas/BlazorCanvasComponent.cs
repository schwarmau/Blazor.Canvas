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
        private Canvas2DContext _context;
        public Canvas2DContext Canvas2DContext
        {
            get
            {
                if (_context == null)
                {
                    _context = new Canvas2DContext(this);
                }

                return _context;
            }
        }
    }
}
