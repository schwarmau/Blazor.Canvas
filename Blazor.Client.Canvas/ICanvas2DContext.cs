using Blazor.Client.Canvas.Enums;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Blazor.Client.Canvas
{
    public interface ICanvas2DContext
    {
        #region Properties
        ElementRef Canvas { get; }
        // TODO: (delete this comment once server-side code implemented) these setters need to be methods (e.g. SetDirection) for server-side since they all need to be done asynchronously with server-side blazor
        string FillStyle { set; }
        string Font { set; }
        float GlobalAlpha { set; }
        CompositionType GlobalCompositeOperation { set; }
        bool ImageSmoothingEnabled { set; }
        LineCap LineCap { set; }
        float LineDashOffset { set; }
        LineJoin LineJoin { set; }
        float LineWidth { set; }
        float MiterLimit { set; }
        float ShadowBlur { set; }
        string ShadowColor { set; }
        float ShadowOffsetX { set; }
        float ShadowOffsetY { set; }
        string StrokeStyle { set; }
        TextAlign TextAlign { set; }
        TextBaseline TextBaseline { set; }
        #endregion

        #region Methods
        Task Arc(float x, float y, float radius, float startAngle, float endAngle, bool antiClockwise = false);
        Task ArcTo(float x1, float y1, float x2, float y2, float radius);
        Task BeginPath();
        // TODO
        #endregion

        #region Batching Support
        void StartBatchOperation();
        void ExecuteBatchOperation();
        #endregion
    }
}
