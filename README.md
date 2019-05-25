# Blazor Canvas

[Work in progress]

#### Example
Page:
```
<BlazorCanvas width="500" height="500" ref="@Canvas" />
```
Component:
```
protected BlazorCanvasComponent Canvas { get; set; }

protected override Task OnAfterRenderAsync()
{
	ICanvas2DContext ctx = Canvas.Canvas2DContext;
	await ctx.MoveTo(0, 0);
	await ctx.LineTo(200, 100);
	await ctx.Stroke();
}
```
Alternatively:
```
ICanvas2DContext ctx = Canvas.Canvas2DContext;
ctx.StartBatchOperation();
await ctx.MoveTo(0, 0);
await ctx.LineTo(200, 100);
await ctx.Stroke();
ctx.ExecuteBatchOperation();
```

Note: Property setting and methods that have return values are not supported by batching. 

I would like to refactor batching to prevent users from making the mistake of performing sets
or using return values in the middle of batching, but the only way I can think of to do that
at the moment is by using a new class (e.g. CanvasBatchOperation), and the only way to make that
condusive to unit testing seems to require a lot of repetitive code.