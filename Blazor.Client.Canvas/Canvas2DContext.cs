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
        public async Task SetFillStyle(string value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.FillStyle, value);
        public async Task SetFont(string value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.Font, value);
        public async Task SetGlobalAlpha(float value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.GlobalAlpha, value);
        public async Task SetGlobalCompositeOperation(CompositionType value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.GlobalCompositeOperation, value);
        public async Task SetImageSmoothingEnabled(bool value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.ImageSmoothingEnabled, value);
        public async Task SetLineCap(LineCap value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.LineCap, value);
        public async Task SetLineDashOffset(float value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.LineDashOffset, value);
        public async Task SetLineJoin(LineJoin value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.LineJoin, value);
        public async Task SetLineWidth(float value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.LineWidth, value);
        public async Task SetMiterLimit(float value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.MiterLimit, value);
        public async Task SetShadowBlur(float value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.ShadowBlur, value);
        public async Task SetShadowColor(string value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.ShadowColor, value);
        public async Task SetShadowOffsetX(float value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.ShadowOffsetX, value);
        public async Task SetShadowOffsetY(float value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.ShadowOffsetY, value);
        public async Task SetStrokeStyle(string value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.StrokeStyle, value);
        public async Task SetTextAlign(TextAlign value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.TextAlign, value);
        public async Task SetTextBaseline(TextBaseline value) => await _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.TextBaseline, value);
        #endregion

        #region Methods
        // TODO: implementation of methods (and contextmethods constants)
        public async Task Arc(float x, float y, float radius, float startAngle, float endAngle, bool antiClockwise = false);
        public async Task ArcTo(float x1, float y1, float x2, float y2, float radius);
        public async Task BeginPath();
        public async Task BezierCurveTo(float cp1x, float cp1y, float cp2x, float cp2y, float x, float y);
        public async Task ClearRect(float x, float y, float width, float height);
        public async Task Clip();
        //public async Task Clip(Path2D path = null); // TODO: implementation will require creating a C# wrapper for Path2D objects
        public async Task Clip(FillRule fillRule);
        //public async Task Clip(FillRule fillRule, Path2D path = null); // TODO: implementation will require creating a C# wrapper for Path2D objects
        public async Task ClosePath();
        //public async Task<ImageData> CreateImageData(float width, float height); // TODO: implementation will require a C# wrapper for ImageData objects
        //public async Task<ImageData> CreateImageData(ImageData imagedata); // TODO: implementation will require a C# wrapper for ImageData objects
        //public async Task<CanvasGradient> CreateLinearGradient(float x0, float y0, float x1, float y1); // TODO: implementation will require a C# wrapper for CanvasGradient objects
        //public async Task<CanvasPattern> CreatePattern(CanvasImageSource image, Repetition repetition); // TODO: implementation will require a C# wrapper for all variations of CanvasImageSource objects, as well as a Repetition enum
        //public async Task<CanvasGradient> CreateRadialGradient(float x0, float y0, float r0, float x1, float y1, float r1); // TODO: implementation will require a C# wrapper for CanvasGradient objects
        //public async Task DrawFocusIfNeeded(HTMLElement element); // TODO: implementation will require a C# wrapper for HTMLElement objects
        //public async Task DrawFocusIfNeeded(Path2D path, HTMLElement element); // TODO: implementation will require a C# wrapper for HTMLElement objects, as well as Path2D objects
        //public async Task DrawImage(CanvasImageSource image, float dx, float dy); // TODO: implementation will require a C# wrapper for all variations of CanvasImageSource objects
        //public async Task DrawImage(CanvasImageSource image, float dx, float dy, float dWidth, float dHeight); // TODO: implementation will require a C# wrapper for all variations of CanvasImageSource objects
        //public async Task DrawImage(CanvasImageSource image, float sx, float sy, float sWidth, float sHeight, float dx, float dy, float dWidth, float dHeight); // TODO: implementation will require a C# wrapper for all variations of CanvasImageSource objects
        public async Task Ellipse(float x, float y, float radiusX, float radiusY, float rotation, float startAngle, float endAngle, bool anticlockwise = false);
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
