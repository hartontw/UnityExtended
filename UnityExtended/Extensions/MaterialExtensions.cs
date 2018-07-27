using System;
using UnityEngine;

namespace UnityExtended
{
    public static partial class Extensions
    {
        #region Color
        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Color> SetColor(this Material self, string name, Color color, float duration)
        {
            LerpCoroutine<Color> coroutine = new LerpCoroutine<Color>(duration,
                new ColorRange(self.GetColor(name), color),
                (l) => { if (self) self.SetColor(name, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Color> SetColor(this Material self, int nameID, Color color, float duration)
        {
            LerpCoroutine<Color> coroutine = new LerpCoroutine<Color>(duration,
                new ColorRange(self.GetColor(nameID), color),
                (l) => { if (self) self.SetColor(nameID, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Color> SetColor(this Material self, Color color, float duration)
        {
            LerpCoroutine<Color> coroutine = new LerpCoroutine<Color>(duration,
                new ColorRange(self.color, color),
                (l) => { if (self) self.color = l; }
            );
            coroutine.Start();
            return coroutine;
        }
        #endregion

        #region Alpha
        /// <summary>
        /// 
        /// </summary>
        public static void SetAlpha(this Material self, string name, float alpha)
        {
            Color color = self.GetColor(name);
            color.a = alpha;
            self.SetColor(name, color);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SetAlpha(this Material self, int nameID, float alpha)
        {
            Color color = self.GetColor(nameID);
            color.a = alpha;
            self.SetColor(nameID, color);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SetAlpha(this Material self, float alpha)
        {
            self.SetAlpha("_Color", alpha);
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<float> SetAlpha(this Material self, string name, float alpha, float duration)
        {
            LerpCoroutine<float> coroutine = new LerpCoroutine<float>(duration, 
                new FloatRange(self.GetColor(name).a, alpha),
                (l) => { if (self) self.SetAlpha(name, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<float> SetAlpha(this Material self, int nameID, float alpha, float duration)
        {
            LerpCoroutine<float> coroutine = new LerpCoroutine<float>(duration,
                new FloatRange(self.GetColor(nameID).a, alpha),
                (l) => { if (self) self.SetAlpha(nameID, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<float> SetAlpha(this Material self, float alpha, float duration)
        {
            LerpCoroutine<float> coroutine = new LerpCoroutine<float>(duration,
                new FloatRange(self.color.a, alpha),
                (l) => { if (self) self.SetAlpha(l); }
            );
            coroutine.Start();
            return coroutine;
        }
        #endregion

        #region TextureOffset
        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureOffset(this Material self, string name, Vector2 offset, float duration)
        {
            LerpCoroutine<Vector2> coroutine = new LerpCoroutine<Vector2>(duration,
                new Vector2Range(self.GetTextureOffset(name), offset),
                (l) => { if (self) self.SetTextureOffset(name, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureOffset(this Material self, int nameID, Vector2 offset, float duration)
        {
            LerpCoroutine<Vector2> coroutine = new LerpCoroutine<Vector2>(duration,
                new Vector2Range(self.GetTextureOffset(nameID), offset),
                (l) => { if (self) self.SetTextureOffset(nameID, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureOffset(this Material self, Vector2 offset, float duration)
        {
            LerpCoroutine<Vector2> coroutine = new LerpCoroutine<Vector2>(duration,
                new Vector2Range(self.mainTextureOffset, offset),
                (l) => { if (self) self.mainTextureOffset = l; }
            );
            coroutine.Start();
            return coroutine;
        }
        #endregion

        #region TextureScale
        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureScale(this Material self, string name, Vector2 scale, float duration)
        {
            LerpCoroutine<Vector2> coroutine = new LerpCoroutine<Vector2>(duration,
                new Vector2Range(self.GetTextureScale(name), scale),
                (l) => { if (self) self.SetTextureScale(name, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureScale(this Material self, int nameID, Vector2 scale, float duration)
        {
            LerpCoroutine<Vector2> coroutine = new LerpCoroutine<Vector2>(duration,
                new Vector2Range(self.GetTextureScale(nameID), scale),
                (l) => { if (self) self.SetTextureScale(nameID, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureScale(this Material self, Vector2 scale, float duration)
        {
            LerpCoroutine<Vector2> coroutine = new LerpCoroutine<Vector2>(duration,
                new Vector2Range(self.mainTextureScale, scale),
                (l) => { if (self) self.mainTextureScale = l; }
            );
            coroutine.Start();
            return coroutine;
        }
        #endregion

        #region Int
        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<int> SetInt(this Material self, string name, int value, float duration)
        {
            LerpCoroutine<int> coroutine = new LerpCoroutine<int>(duration,
                new IntRange(self.GetInt(name), value),
                (l) => { if (self) self.SetInt(name, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<int> SetFloat(this Material self, int nameID, int value, float duration)
        {
            LerpCoroutine<int> coroutine = new LerpCoroutine<int>(duration,
                new IntRange(self.GetInt(nameID), value),
                (l) => { if (self) self.SetInt(nameID, l); }
            );
            coroutine.Start();
            return coroutine;
        }
        #endregion

        #region Float
        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<float> SetFloat(this Material self, string name, float value, float duration)
        {
            LerpCoroutine<float> coroutine = new LerpCoroutine<float>(duration,
                new FloatRange(self.GetFloat(name), value),
                (l) => { if (self) self.SetFloat(name, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<float> SetFloat(this Material self, int nameID, float value, float duration)
        {
            LerpCoroutine<float> coroutine = new LerpCoroutine<float>(duration,
                new FloatRange(self.GetFloat(nameID), value),
                (l) => { if (self) self.SetFloat(nameID, l); }
            );
            coroutine.Start();
            return coroutine;
        }
        #endregion

        #region Vector
        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector4> SetVector(this Material self, string name, Vector4 value, float duration)
        {
            LerpCoroutine<Vector4> coroutine = new LerpCoroutine<Vector4>(duration,
                new Vector4Range(self.GetVector(name), value),
                (l) => { if (self) self.SetVector(name, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector4> SetFloat(this Material self, int nameID, Vector4 value, float duration)
        {
            LerpCoroutine<Vector4> coroutine = new LerpCoroutine<Vector4>(duration,
                new Vector4Range(self.GetVector(nameID), value),
                (l) => { if (self) self.SetVector(nameID, l); }
            );
            coroutine.Start();
            return coroutine;
        }
        #endregion
    }
}
