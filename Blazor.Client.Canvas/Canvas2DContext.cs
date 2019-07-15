using Blazor.Client.Canvas.Constants;
using Blazor.Client.Canvas.Enums;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazor.Client.Canvas
{
    public class Canvas2DContext
    {
        private IJSRuntime _jsRuntime;
        public ElementRef Canvas { get; }

        internal Canvas2DContext(BlazorCanvasComponent component)
        {
            Canvas = component.CanvasRef;
            _jsRuntime = component.Runtime;
        }

        #region Properties
        public Task SetFillStyle(string value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.FillStyle, new[] { value });
        public Task SetFont(string value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.Font, new[] { value });
        public Task SetGlobalAlpha(float value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.GlobalAlpha, new[] { value });
        public Task SetGlobalCompositeOperation(CompositionType value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.GlobalCompositeOperation, new[] { value });
        public Task SetImageSmoothingEnabled(bool value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.ImageSmoothingEnabled, new[] { value });
        public Task SetLineCap(LineCap value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.LineCap, new[] { value });
        public Task SetLineDashOffset(float value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.LineDashOffset, new[] { value });
        public Task SetLineJoin(LineJoin value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.LineJoin, new[] { value });
        public Task SetLineWidth(float value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.LineWidth, new[] { value });
        public Task SetMiterLimit(float value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.MiterLimit, new[] { value });
        public Task SetShadowBlur(float value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.ShadowBlur, new[] { value });
        public Task SetShadowColor(string value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.ShadowColor, new[] { value });
        public Task SetShadowOffsetX(float value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.ShadowOffsetX, new[] { value });
        public Task SetShadowOffsetY(float value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.ShadowOffsetY, new[] { value });
        public Task SetStrokeStyle(string value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.StrokeStyle, new[] { value });
        public Task SetTextAlign(TextAlign value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.TextAlign, new[] { value });
        public Task SetTextBaseline(TextBaseline value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.TextBaseline, new[] { value });
        #endregion

        #region Methods
        // TODO: implementation of methods (and contextmethods constants)
        public Task Arc(float x, float y, float radius, float startAngle, float endAngle, bool antiClockwise = false);
        public Task ArcTo(float x1, float y1, float x2, float y2, float radius);
        public Task BeginPath();
        public Task BezierCurveTo(float cp1x, float cp1y, float cp2x, float cp2y, float x, float y);
        public Task ClearRect(float x, float y, float width, float height);
        public Task Clip();
        //public Task Clip(Path2D path = null); // TODO: implementation will require creating a C# wrapper for Path2D objects
        public Task Clip(FillRule fillRule);
        //public Task Clip(FillRule fillRule, Path2D path = null); // TODO: implementation will require creating a C# wrapper for Path2D objects
        public Task ClosePath();
        //public Task<ImageData> CreateImageData(float width, float height); // TODO: implementation will require a C# wrapper for ImageData objects
        //public Task<ImageData> CreateImageData(ImageData imagedata); // TODO: implementation will require a C# wrapper for ImageData objects
        //public Task<CanvasGradient> CreateLinearGradient(float x0, float y0, float x1, float y1); // TODO: implementation will require a C# wrapper for CanvasGradient objects
        //public Task<CanvasPattern> CreatePattern(CanvasImageSource image, Repetition repetition); // TODO: implementation will require a C# wrapper for all variations of CanvasImageSource objects, as well as a Repetition enum
        //public Task<CanvasGradient> CreateRadialGradient(float x0, float y0, float r0, float x1, float y1, float r1); // TODO: implementation will require a C# wrapper for CanvasGradient objects
        //public Task DrawFocusIfNeeded(HTMLElement element); // TODO: implementation will require a C# wrapper for HTMLElement objects
        //public Task DrawFocusIfNeeded(Path2D path, HTMLElement element); // TODO: implementation will require a C# wrapper for HTMLElement objects, as well as Path2D objects
        //public Task DrawImage(CanvasImageSource image, float dx, float dy); // TODO: implementation will require a C# wrapper for all variations of CanvasImageSource objects
        //public Task DrawImage(CanvasImageSource image, float dx, float dy, float dWidth, float dHeight); // TODO: implementation will require a C# wrapper for all variations of CanvasImageSource objects
        //public Task DrawImage(CanvasImageSource image, float sx, float sy, float sWidth, float sHeight, float dx, float dy, float dWidth, float dHeight); // TODO: implementation will require a C# wrapper for all variations of CanvasImageSource objects
        public Task Ellipse(float x, float y, float radiusX, float radiusY, float rotation, float startAngle, float endAngle, bool anticlockwise = false);
        // TODO: remaining methods
        #endregion

        #region Batching Support
        public async Task ExecuteBatch(Canvas2DBatch batch)
        {
            await _jsRuntime.InvokeAsync<Task>("canvasOperator.executeCanvasBatch", Canvas, batch.Calls);
        }
        #endregion
    }
}
