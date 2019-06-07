var contextPrototype = CanvasRenderingContext2D.prototype;

window.canvasOperator = {
    setCanvasProperty: function (canvas, propertyName, value) {
        var ctx = canvas.getContext('2d');
        ctx[propertyName] = value;
    },

    callCanvasMethod: function (canvas, methodName, args) {
        var ctx = canvas.getContext('2d');
        contextPrototype[methodName].apply(ctx, args);
    },

    // TODO: add function(s) for calls that need to return something

    executeCanvasBatch: function (canvas, calls) {
        var ctx = canvas.getContext('2d');
        calls.forEach(function (call) {
            contextPrototype[call[0]].apply(ctx, call[1]);
        });
    }
};