using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// v1 ------- v3
    /// |          |
    /// |          |
    /// v2 ------- v4
    /// </summary>
    public class UISegment
    {
        public readonly UIVertex[] vertex;

        public Vector2 v1 { get { return vertex[0].position; } set { SetVertex(0, value); } }
        public Vector2 v2 { get { return vertex[1].position; } set { SetVertex(1, value); } }
        public Vector2 v3 { get { return vertex[2].position; } set { SetVertex(2, value); } }
        public Vector2 v4 { get { return vertex[3].position; } set { SetVertex(3, value); } }

        public UIVertex this[int i] { get { return vertex[i]; } set { vertex[i] = value; } }

        public Vector2 start { get { return v1 + (v2 - v1) * 0.5F; } }
        public Vector2 end { get { return v3 + (v4 - v3) * 0.5F; } }

        public Color color { get; protected set; }
        public float width { get; protected set; }

        public UISegment(Vector2 start, Vector2 end, Color color, float width)
        {
            this.color = color;
            this.width = width;

            vertex = new UIVertex[4];

            GenerateVertex(start, end);
        }

        protected void SetColor(Color color)
        {
            this.color = color;
            GenerateVertex(start, end);
        }

        protected void SetWidth(float width)
        {
            this.width = width;
            GenerateVertex(start, end);
        }

        protected void GenerateVertex(Vector2 start, Vector2 end)
        {
            Vector2 direction = end - start;

            Vector2 slide = new Vector2(-direction.y, direction.x).normalized * width * 0.5F;

            vertex[0] = NewVertex(start + slide);
            vertex[1] = NewVertex(start - slide);
            vertex[2] = NewVertex(end + slide);
            vertex[3] = NewVertex(end - slide);
        }

        public void SetVertex(int index, Vector2 point) { vertex[index] = NewVertex(point); }

        protected UIVertex NewVertex(Vector2 point)
        {
            UIVertex vertex = UIVertex.simpleVert;
            vertex.position = point;
            vertex.color = color;
            return vertex;
        }
    }
}
