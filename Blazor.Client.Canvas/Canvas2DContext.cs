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
        public Task SetFillStyle(string value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.FillStyle, value);
        public Task SetFont(string value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.Font, value);
        public Task SetGlobalAlpha(float value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.GlobalAlpha, value);
        public Task SetGlobalCompositeOperation(CompositionType value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.GlobalCompositeOperation, value);
        public Task SetImageSmoothingEnabled(bool value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.ImageSmoothingEnabled, value);
        public Task SetLineCap(LineCap value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.LineCap, value);
        public Task SetLineDashOffset(float value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.LineDashOffset, value);
        public Task SetLineJoin(LineJoin value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.LineJoin, value);
        public Task SetLineWidth(float value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.LineWidth, value);
        public Task SetMiterLimit(float value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.MiterLimit, value);
        public Task SetShadowBlur(float value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.ShadowBlur, value);
        public Task SetShadowColor(string value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.ShadowColor, value);
        public Task SetShadowOffsetX(float value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.ShadowOffsetX, value);
        public Task SetShadowOffsetY(float value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.ShadowOffsetY, value);
        public Task SetStrokeStyle(string value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.StrokeStyle, value);
        public Task SetTextAlign(TextAlign value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.TextAlign, value);
        public Task SetTextBaseline(TextBaseline value) => _jsRuntime.InvokeAsync<Task>("canvasOperator.setCanvasProperty", Canvas, ContextProperties.TextBaseline, value);
		#endregion

		#region Methods
		// TODO: implementation of methods (and contextmethods constants)
		public Task Arc(float x, float y, float radius, float startAngle, float endAngle, bool antiClockwise = false) => _jsRuntime.InvokeAsync<Task>("canvasOperator.callCanvasMethod", Canvas, ContextMethods.Arc, new object[] { x, y, radius, startAngle, endAngle, antiClockwise });
        public Task ArcTo(float x1, float y1, float x2, float y2, float radius);
        public Task BeginPath();
        public Task BezierCurveTo(float cp1x, float cp1y, float cp2x, float cp2y, float x, float y);
        public Task ClearRect(float x, float y, float width, float height);
        public Task Clip();
        //public Task Clip(Path2D path); // TODO: implementation will require creating a C# wrapper for Path2D objects
        public Task Clip(FillRule fillRule = FillRule.NonZero);
		//public Task Clip(Path2D path, FillRule fillRule = FillRule.NonZero); // TODO: implementation will require creating a C# wrapper for Path2D objects
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
		public Task Fill(FillRule fillRule = FillRule.NonZero);
		//public Task Fill(Path2D path, FillRule fillRule = FillRule.NonZero); // TODO: implementation will require creating a C# wrapper for Path2D objects
		public Task FillRect(float x, float y, float width, float height);
		public Task FillText(string text, float x, float y);
		public Task FillText(string text, float x, float y, int maxWidth);
		//public Task<ImageData> GetImageData(float sx, float sy, float sw, float sh); // TODO: implementation will require a C# wrapper for ImageData objects
		public Task<float[]> GetLineDash();
		public Task<bool> IsPointInPath(float x, float y, FillRule fillRule = FillRule.NonZero);
		//public Task<bool> IsPointInPath(Path2D path, float x, float y, FillRule fillRule = FillRule.NonZero); // TODO: implementation will require creating a C# wrapper for Path2D objects
		public Task<bool> IsPointInStroke(float x, float y);
		//public Task<bool> IsPointInStroke(Path2D path, float x, float y); // TODO: implementation will require creating a C# wrapper for Path2D objects
		public Task LineTo(float x, float y);
		//public Task<TextMetrics> MeasureText(string text); // TODO: implementation will require creating a C# wrapper for TextMetrics objects
        public Task MoveTo(float x, float y);
		//public Task PutImageData(ImageData imageData, float dx, float dy); // TODO: implementation will require a C# wrapper for ImageData objects
		//public Task PutImageData(ImageData imageData, float dx, float dy, float dirtyX, float dirtyY, float dirtyWidth, float dirtyHeight); // TODO: implementation will require a C# wrapper for ImageData objects
		public Task QuadraticCurveTo(float cpx, float cpy, float x, float y);
		public Task Rect(float x, float y, float width, float height);
		public Task Restore();
		public Task Rotate(double angle);
		public Task Save();
		public Task Scale(double x, double y);
		public Task SetLineDash(float[] segments);
		public Task SetTransform(double a, double b, double c, double d, float e, float f);
		//public Task SetTransform(DOMMatrixInit matrix); // TODO: implementation will require a C# wrapper for DOMMatrixInit objects
		public Task Stroke();
		//public Task Stroke(Path2D path); // TODO: implementation will require a C# wrapper for Path2D objects
		public Task StrokeRect(float x, float y, float width, float height);
		public Task StrokeText(string text, float x, float y);
		public Task StrokeText(string text, float x, float y, int maxWidth);
		public Task Transform(double a, double b, double c, double d, float e, float f);
		//public Task Transform(DOMMatrixInit matrix); // TODO: implementation will require a C# wrapper for DOMMatrixInit objects
		public Task Translate(float x, float y);
		#endregion

        #region Batching Support
        public async Task ExecuteBatch(Canvas2DBatch batch)
        {
            await _jsRuntime.InvokeAsync<Task>("canvasOperator.executeCanvasBatch", Canvas, batch.Calls);
        }
        #endregion
    }
}
