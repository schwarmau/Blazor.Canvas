using System.Collections.Generic;

namespace Blazor.Client.Canvas
{
    public class Canvas2DBatch
    {
        private List<object[]> _calls;
        internal object[][] Calls => _calls.ToArray();

        public Canvas2DBatch()
        {
            _calls = new List<object[]>();
        }

        // TODO: copy methods without return values from Canvas2DContext and implement them
        /*
         * e.g.
         * public Canvas2DBatch ArcTo(float x1, float y1, float x2, float y2, float radius)
         * {
         * * _calls.Add(new object[]
         * * {
         * * * ContextMethods.ArcTo,
         * * * new object[] { x1, y1, x2, y2, radius }
         * * });
         * * 
         * * return this;
         * }
         */
    }
}
