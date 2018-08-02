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
        public static LerpCoroutine<Color> SetColor(this Material self, string name, Color color, float duration, Func<float, float> function)
        {
            LerpCoroutine<Color> coroutine = new LerpCoroutine<Color>(duration,
                new ColorRange(self.GetColor(name), color), function,
                (l) => { if (self) self.SetColor(name, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Color> SetColor(this Material self, string name, Color color, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetColor(name, color, duration, Easing.Get(function));
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Color> SetColor(this Material self, int nameID, Color color, float duration, Func<float, float> function)
        {
            LerpCoroutine<Color> coroutine = new LerpCoroutine<Color>(duration,
                new ColorRange(self.GetColor(nameID), color), function,
                (l) => { if (self) self.SetColor(nameID, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Color> SetColor(this Material self, int nameID, Color color, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetColor(nameID, color, duration, Easing.Get(function));
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Color> SetColor(this Material self, Color color, float duration, Func<float, float> function)
        {
            LerpCoroutine<Color> coroutine = new LerpCoroutine<Color>(duration,
                new ColorRange(self.color, color), function,
                (l) => { if (self) self.color = l; }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Color> SetColor(this Material self, Color color, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetColor(color, duration, Easing.Get(function));
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
        public static LerpCoroutine<float> SetAlpha(this Material self, string name, float alpha, float duration, Func<float, float> function)
        {
            LerpCoroutine<float> coroutine = new LerpCoroutine<float>(duration,
                new FloatRange(self.GetColor(name).a, alpha), function,
                (l) => { if (self) self.SetAlpha(name, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<float> SetAlpha(this Material self, string name, float alpha, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetAlpha(name, alpha, duration, Easing.Get(function));
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<float> SetAlpha(this Material self, int nameID, float alpha, float duration, Func<float, float> function)
        {
            LerpCoroutine<float> coroutine = new LerpCoroutine<float>(duration,
                new FloatRange(self.GetColor(nameID).a, alpha), function,
                (l) => { if (self) self.SetAlpha(nameID, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<float> SetAlpha(this Material self, int nameID, float alpha, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetAlpha(nameID, alpha, duration, Easing.Get(function));
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<float> SetAlpha(this Material self, float alpha, float duration, Func<float, float> function)
        {
            LerpCoroutine<float> coroutine = new LerpCoroutine<float>(duration,
                new FloatRange(self.color.a, alpha), function,
                (l) => { if (self) self.SetAlpha(l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<float> SetAlpha(this Material self, float alpha, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetAlpha(alpha, duration, Easing.Get(function));
        }
        #endregion

        #region TextureOffset
        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureOffset(this Material self, string name, Vector2 offset, float duration, Func<float, float> function)
        {
            LerpCoroutine<Vector2> coroutine = new LerpCoroutine<Vector2>(duration,
                new Vector2Range(self.GetTextureOffset(name), offset), function,
                (l) => { if (self) self.SetTextureOffset(name, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureOffset(this Material self, string name, Vector2 offset, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetTextureOffset(name, offset, duration, Easing.Get(function));
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureOffset(this Material self, int nameID, Vector2 offset, float duration, Func<float, float> function)
        {
            LerpCoroutine<Vector2> coroutine = new LerpCoroutine<Vector2>(duration,
                new Vector2Range(self.GetTextureOffset(nameID), offset), function,
                (l) => { if (self) self.SetTextureOffset(nameID, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureOffset(this Material self, int nameID, Vector2 offset, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetTextureOffset(nameID, offset, duration, Easing.Get(function));
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureOffset(this Material self, Vector2 offset, float duration, Func<float, float> function)
        {
            LerpCoroutine<Vector2> coroutine = new LerpCoroutine<Vector2>(duration,
                new Vector2Range(self.mainTextureOffset, offset), function,
                (l) => { if (self) self.mainTextureOffset = l; }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureOffset(this Material self, Vector2 offset, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetTextureOffset(offset, duration, Easing.Get(function));
        }
        #endregion

        #region TextureScale
        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureScale(this Material self, string name, Vector2 scale, float duration, Func<float, float> function)
        {
            LerpCoroutine<Vector2> coroutine = new LerpCoroutine<Vector2>(duration,
                new Vector2Range(self.GetTextureScale(name), scale), function,
                (l) => { if (self) self.SetTextureScale(name, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureScale(this Material self, string name, Vector2 scale, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetTextureScale(name, scale, duration, Easing.Get(function));
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureScale(this Material self, int nameID, Vector2 scale, float duration, Func<float, float> function)
        {
            LerpCoroutine<Vector2> coroutine = new LerpCoroutine<Vector2>(duration,
                new Vector2Range(self.GetTextureScale(nameID), scale), function,
                (l) => { if (self) self.SetTextureScale(nameID, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureScale(this Material self, int nameID, Vector2 scale, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetTextureScale(nameID, scale, duration, Easing.Get(function));
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureScale(this Material self, Vector2 scale, float duration, Func<float, float> function)
        {
            LerpCoroutine<Vector2> coroutine = new LerpCoroutine<Vector2>(duration,
                new Vector2Range(self.mainTextureScale, scale), function,
                (l) => { if (self) self.mainTextureScale = l; }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector2> SetTextureScale(this Material self, Vector2 scale, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetTextureScale(scale, duration, Easing.Get(function));
        }
        #endregion

        #region Int
        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<int> SetInt(this Material self, string name, int value, float duration, Func<float, float> function)
        {
            LerpCoroutine<int> coroutine = new LerpCoroutine<int>(duration,
                new IntRange(self.GetInt(name), value), function,
                (l) => { if (self) self.SetInt(name, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<int> SetInt(this Material self, string name, int value, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetInt(name, value, duration, Easing.Get(function));
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<int> SetInt(this Material self, int nameID, int value, float duration, Func<float, float> function)
        {
            LerpCoroutine<int> coroutine = new LerpCoroutine<int>(duration,
                new IntRange(self.GetInt(nameID), value), function,
                (l) => { if (self) self.SetInt(nameID, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<int> SetInt(this Material self, int nameID, int value, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetInt(nameID, value, duration, Easing.Get(function));
        }
        #endregion

        #region Float
        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<float> SetFloat(this Material self, string name, float value, float duration, Func<float, float> function)
        {
            LerpCoroutine<float> coroutine = new LerpCoroutine<float>(duration,
                new FloatRange(self.GetFloat(name), value), function,
                (l) => { if (self) self.SetFloat(name, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<float> SetFloat(this Material self, string name, float value, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetFloat(name, value, duration, Easing.Get(function));
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<float> SetFloat(this Material self, int nameID, float value, float duration, Func<float, float> function)
        {
            LerpCoroutine<float> coroutine = new LerpCoroutine<float>(duration,
                new FloatRange(self.GetFloat(nameID), value), function,
                (l) => { if (self) self.SetFloat(nameID, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<float> SetFloat(this Material self, int nameID, float value, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetFloat(nameID, value, duration, Easing.Get(function));
        }
        #endregion

        #region Vector
        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector4> SetVector(this Material self, string name, Vector4 value, float duration, Func<float, float> function)
        {
            LerpCoroutine<Vector4> coroutine = new LerpCoroutine<Vector4>(duration,
                new Vector4Range(self.GetVector(name), value), function,
                (l) => { if (self) self.SetVector(name, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector4> SetVector(this Material self, string name, Vector4 value, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetVector(name, value, duration, Easing.Get(function));
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector4> SetVector(this Material self, int nameID, Vector4 value, float duration, Func<float, float> function)
        {
            LerpCoroutine<Vector4> coroutine = new LerpCoroutine<Vector4>(duration,
                new Vector4Range(self.GetVector(nameID), value), function,
                (l) => { if (self) self.SetVector(nameID, l); }
            );
            coroutine.Start();
            return coroutine;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LerpCoroutine<Vector4> SetVector(this Material self, int nameID, Vector4 value, float duration, Easing.Functions function = Easing.Functions.Linear)
        {
            return self.SetVector(nameID, value, duration, Easing.Get(function));
        }
        #endregion
    }
}
