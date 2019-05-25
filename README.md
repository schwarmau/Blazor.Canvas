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