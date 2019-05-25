﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Blazor.Client.Canvas
{
    public class Canvas2DContext : ICanvas2DContext
    {
        private IJSRuntime _jsRuntime;
        public ElementRef Canvas { get; }

        internal Canvas2DContext(BlazorCanvasComponent component)
        {
            Canvas = component.CanvasRef;
            _jsRuntime = component.Runtime;
        }

        /*
         * TODO: figure out how to support batching
         * * current idea is have a delegate method that the canvas2dcontext calls in each void method call
         * * * e.g. private delegate Task ConductCall(string methodName, object[] args)
         * * * and the methods would call it like: LineTo(long x, long y) { ConductCall("lineTo", new object[2] { x, y }); }
         * * set the delegate in the constructor to default to => await _jsRuntime.InvokeAsync("canvasOperator.callCanvasMethod", methodName, args)
         * * when StartBatchOperation() is called, set the delegate to => await Task.Run(() => batch.Add(new object[2] { methodName, args }))
         * * * obviously this class will therefore need an enumerable to hold the batch
         * * when ExecuteBatchOperation() is called, call await _jsRuntime.InvokeAsync("canvasOperator.executeCanvasBatchOperation", batch.ToArray()) and set the delegate back to normal
         */
        // TODO: implement interface
    }
}
