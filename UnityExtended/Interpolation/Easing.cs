using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UnityExtended
{
    public static class Easing
    {
        /// <summary>
        /// 
        /// </summary>
        public enum Functions
        {
            Linear,
            EaseInSine,
            EaseOutSine,
            EaseInOutSine,
            EaseOutInSine,
            EaseInQuad,
            EaseOutQuad,
            EaseInOutQuad,
            EaseOutInQuad,
            EaseInCubic,
            EaseOutCubic,
            EaseInOutCubic,
            EaseOutInCubic,
            EaseInQuart,
            EaseOutQuart,
            EaseInOutQuart,
            EaseOutInQuart,
            EaseInQuint,
            EaseOutQuint,
            EaseInOutQuint,
            EaseOutInQuint,
            EaseInExp,
            EaseOutExp,
            EaseInOutExp,
            EaseOutInExp,
            EaseInCirc,
            EaseOutCirc,
            EaseInOutCirc,
            EaseOutInCirc,
            EaseInBack,
            EaseOutBack,
            EaseInOutBack,
            EaseOutInBack,
            EaseInElastic,
            EaseOutElastic,
            EaseInOutElastic,
            EaseOutInElastic,
            EaseInBounce,
            EaseOutBounce,
            EaseInOutBounce,
            EaseOutInBounce,
        }

        /// <summary>
        /// 
        /// </summary>
        public static float Linear(float t) { return t; }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOut(float t, Func<float, float> easein, Func<float, float> easeout)
        {
            t *= 2F;
            return t < 1F ? easein(t) * 0.5f : easeout(t - 1F) * 0.5f + 0.5f;
        }

        #region EaseInSine
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInSine(float t)
        {
            return 1F - HMath.Cos(t * HMath.HalfPI);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInSine(float t, float d)
        {
            return EaseInSine(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInSine(float a, float b, float t)
        {
            return a + (b - a) * EaseInSine(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInSine(float a, float b, float t, float d)
        {
            return EaseInSine(a, b, t / d);
        }
        #endregion

        #region EaseOutSine
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutSine(float t)
        {
            return HMath.Sin(t * HMath.HalfPI);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutSine(float t, float d)
        {
            return EaseOutSine(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutSine(float a, float b, float t)
        {
            return a + (b - a) * EaseOutSine(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutSine(float a, float b, float t, float d)
        {
            return EaseOutSine(a, b, t / d);
        }
        #endregion

        #region EaseInOutSine
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutSine(float t)
        {
            return EaseInOut(t, EaseInSine, EaseOutSine);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutSine(float t, float d)
        {
            return EaseInOutSine(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutSine(float a, float b, float t)
        {
            return a + (b - a) * EaseInOutSine(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutSine(float a, float b, float t, float d)
        {
            return EaseInOutSine(a, b, t / d);
        }
        #endregion

        #region EaseOutInSine
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInSine(float t)
        {
            return EaseInOut(t, EaseOutSine, EaseInSine);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInSine(float t, float d)
        {
            return EaseOutInSine(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInSine(float a, float b, float t)
        {
            return a + (b - a) * EaseOutInSine(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInSine(float a, float b, float t, float d)
        {
            return EaseOutInSine(a, b, t / d);
        }
        #endregion

        #region EaseInQuad
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInQuad(float t)
        {
            return t * t;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInQuad(float t, float d)
        {
            return EaseInQuad(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInQuad(float a, float b, float t)
        {
            return a + (b - a) * EaseInQuad(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInQuad(float a, float b, float t, float d)
        {
            return EaseInQuad(a, b, t / d);
        }
        #endregion

        #region EaseOutQuad
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutQuad(float t)
        {
            t = 1F - t;
            return 1F - t * t;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutQuad(float t, float d)
        {
            return EaseOutQuad(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutQuad(float a, float b, float t)
        {
            return a + (b - a) * EaseOutQuad(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutQuad(float a, float b, float t, float d)
        {
            return EaseOutQuad(a, b, t / d);
        }
        #endregion

        #region EaseInOutQuad
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutQuad(float t)
        {
            return EaseInOut(t, EaseInQuad, EaseOutQuad);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutQuad(float t, float d)
        {
            return EaseInOutQuad(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutQuad(float a, float b, float t)
        {
            return a + (b - a) * EaseInOutQuad(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutQuad(float a, float b, float t, float d)
        {
            return EaseInOutQuad(a, b, t / d);
        }
        #endregion

        #region EaseOutInQuad
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInQuad(float t)
        {
            return EaseInOut(t, EaseOutQuad, EaseInQuad);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInQuad(float t, float d)
        {
            return EaseOutInQuad(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInQuad(float a, float b, float t)
        {
            return a + (b - a) * EaseOutInQuad(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInQuad(float a, float b, float t, float d)
        {
            return EaseOutInQuad(a, b, t / d);
        }
        #endregion

        #region EaseInCubic
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInCubic(float t)
        {
            return t * t * t;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInCubic(float t, float d)
        {
            return EaseInCubic(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInCubic(float a, float b, float t)
        {
            return a + (b - a) * EaseInCubic(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInCubic(float a, float b, float t, float d)
        {
            return EaseInCubic(a, b, t / d);
        }
        #endregion

        #region EaseOutCubic
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutCubic(float t)
        {
            t = 1F - t;
            return 1F - t * t * t;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutCubic(float t, float d)
        {
            return EaseOutCubic(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutCubic(float a, float b, float t)
        {
            return a + (b - a) * EaseOutCubic(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutCubic(float a, float b, float t, float d)
        {
            return EaseOutCubic(a, b, t / d);
        }
        #endregion

        #region EaseInOutCubic
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutCubic(float t)
        {
            return EaseInOut(t, EaseInCubic, EaseOutCubic);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutCubic(float t, float d)
        {
            return EaseInOutCubic(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutCubic(float a, float b, float t)
        {
            return a + (b - a) * EaseInOutCubic(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutCubic(float a, float b, float t, float d)
        {
            return EaseInOutCubic(a, b, t / d);
        }
        #endregion

        #region EaseOutInCubic
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInCubic(float t)
        {
            return EaseInOut(t, EaseOutCubic, EaseInCubic);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInCubic(float t, float d)
        {
            return EaseOutInCubic(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInCubic(float a, float b, float t)
        {
            return a + (b - a) * EaseOutInCubic(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInCubic(float a, float b, float t, float d)
        {
            return EaseOutInCubic(a, b, t / d);
        }
        #endregion

        #region EaseInQuart
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInQuart(float t)
        {
            return t * t * t * t;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInQuart(float t, float d)
        {
            return EaseInQuart(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInQuart(float a, float b, float t)
        {
            return a + (b - a) * EaseInQuart(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInQuart(float a, float b, float t, float d)
        {
            return EaseInQuart(a, b, t / d);
        }
        #endregion

        #region EaseOutQuart
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutQuart(float t)
        {
            t = 1F - t;
            return 1F - t * t * t * t;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutQuart(float t, float d)
        {
            return EaseOutQuart(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutQuart(float a, float b, float t)
        {
            return a + (b - a) * EaseOutQuart(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutQuart(float a, float b, float t, float d)
        {
            return EaseOutQuart(a, b, t / d);
        }
        #endregion

        #region EaseInOutQuart
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutQuart(float t)
        {
            return EaseInOut(t, EaseInQuart, EaseOutQuart);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutQuart(float t, float d)
        {
            return EaseInOutQuart(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutQuart(float a, float b, float t)
        {
            return a + (b - a) * EaseInOutQuart(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutQuart(float a, float b, float t, float d)
        {
            return EaseInOutQuart(a, b, t / d);
        }
        #endregion

        #region EaseOutInQuart
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInQuart(float t)
        {
            return EaseInOut(t, EaseOutQuart, EaseInQuart);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInQuart(float t, float d)
        {
            return EaseOutInQuart(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInQuart(float a, float b, float t)
        {
            return a + (b - a) * EaseOutInQuart(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInQuart(float a, float b, float t, float d)
        {
            return EaseOutInQuart(a, b, t / d);
        }
        #endregion

        #region EaseInQuint
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInQuint(float t)
        {
            return t * t * t * t * t;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInQuint(float t, float d)
        {
            return EaseInQuint(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInQuint(float a, float b, float t)
        {
            return a + (b - a) * EaseInQuint(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInQuint(float a, float b, float t, float d)
        {
            return EaseInQuint(a, b, t / d);
        }
        #endregion

        #region EaseOutQuint
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutQuint(float t)
        {
            t = 1F - t;
            return 1F - t * t * t * t * t;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutQuint(float t, float d)
        {
            return EaseOutQuint(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutQuint(float a, float b, float t)
        {
            return a + (b - a) * EaseOutQuint(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutQuint(float a, float b, float t, float d)
        {
            return EaseOutQuint(a, b, t / d);
        }
        #endregion

        #region EaseInOutQuint
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutQuint(float t)
        {
            return EaseInOut(t, EaseInQuint, EaseOutQuint);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutQuint(float t, float d)
        {
            return EaseInOutQuint(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutQuint(float a, float b, float t)
        {
            return a + (b - a) * EaseInOutQuint(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutQuint(float a, float b, float t, float d)
        {
            return EaseInOutQuint(a, b, t / d);
        }
        #endregion

        #region EaseOutInQuint
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInQuint(float t)
        {
            return EaseInOut(t, EaseOutQuint, EaseInQuint);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInQuint(float t, float d)
        {
            return EaseOutInQuint(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInQuint(float a, float b, float t)
        {
            return a + (b - a) * EaseOutInQuint(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInQuint(float a, float b, float t, float d)
        {
            return EaseOutInQuint(a, b, t / d);
        }
        #endregion

        #region EaseInExp
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInExp(float t)
        {
            return t != 0 ? HMath.Pow(2F, 10F * (t - 1F)) : 0F;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInExp(float t, float d)
        {
            return EaseInExp(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInExp(float a, float b, float t)
        {
            return a + (b - a) * EaseInExp(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInExp(float a, float b, float t, float d)
        {
            return EaseInExp(a, b, t / d);
        }
        #endregion

        #region EaseOutExp
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutExp(float t)
        {
            return t != 1F ? 1F - HMath.Pow(2F, -10F * t) : 1F;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutExp(float t, float d)
        {
            return EaseOutExp(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutExp(float a, float b, float t)
        {
            return a + (b - a) * EaseOutExp(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutExp(float a, float b, float t, float d)
        {
            return EaseOutExp(a, b, t / d);
        }
        #endregion

        #region EaseInOutExp
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutExp(float t)
        {
            return EaseInOut(t, EaseInExp, EaseOutExp);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutExp(float t, float d)
        {
            return EaseInOutExp(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutExp(float a, float b, float t)
        {
            return a + (b - a) * EaseInOutExp(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutExp(float a, float b, float t, float d)
        {
            return EaseInOutExp(a, b, t / d);
        }
        #endregion

        #region EaseOutInExp
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInExp(float t)
        {
            return EaseInOut(t, EaseOutExp, EaseInExp);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInExp(float t, float d)
        {
            return EaseOutInExp(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInExp(float a, float b, float t)
        {
            return a + (b - a) * EaseOutInExp(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInExp(float a, float b, float t, float d)
        {
            return EaseOutInExp(a, b, t / d);
        }
        #endregion

        #region EaseInCirc
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInCirc(float t)
        {
            return 1F - HMath.Sqrt(1F - t * t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInCirc(float t, float d)
        {
            return EaseInCirc(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInCirc(float a, float b, float t)
        {
            return a + (b - a) * EaseInCirc(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInCirc(float a, float b, float t, float d)
        {
            return EaseInCirc(a, b, t / d);
        }
        #endregion

        #region EaseOutCirc
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutCirc(float t)
        {
            t = 1F - t;
            return HMath.Sqrt(1F - t * t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutCirc(float t, float d)
        {
            return EaseOutCirc(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutCirc(float a, float b, float t)
        {
            return a + (b - a) * EaseOutCirc(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutCirc(float a, float b, float t, float d)
        {
            return EaseOutCirc(a, b, t / d);
        }
        #endregion

        #region EaseInOutCirc
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutCirc(float t)
        {
            return EaseInOut(t, EaseInCirc, EaseOutCirc);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutCirc(float t, float d)
        {
            return EaseInOutCirc(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutCirc(float a, float b, float t)
        {
            return a + (b - a) * EaseInOutCirc(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutCirc(float a, float b, float t, float d)
        {
            return EaseInOutCirc(a, b, t / d);
        }
        #endregion

        #region EaseOutInCirc
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInCirc(float t)
        {
            return EaseInOut(t, EaseOutCirc, EaseInCirc);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInCirc(float t, float d)
        {
            return EaseOutInCirc(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInCirc(float a, float b, float t)
        {
            return a + (b - a) * EaseOutInCirc(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInCirc(float a, float b, float t, float d)
        {
            return EaseOutInCirc(a, b, t / d);
        }
        #endregion

        #region EaseInBack
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInBack(float t)
        {
            const float c = 1.70158f;
            return t * t * ((c + 1F) * t - c);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInBack(float t, float d)
        {
            return EaseInBack(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInBack(float a, float b, float t)
        {
            return a + (b - a) * EaseInBack(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInBack(float a, float b, float t, float d)
        {
            return EaseInBack(a, b, t / d);
        }
        #endregion

        #region EaseOutBack
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutBack(float t)
        {
            const float c = 1.70158f;
            t -= 1F;
            return t * t * ((c + 1F) * t + c) + 1F;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutBack(float t, float d)
        {
            return EaseOutBack(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutBack(float a, float b, float t)
        {
            return a + (b - a) * EaseOutBack(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutBack(float a, float b, float t, float d)
        {
            return EaseOutBack(a, b, t / d);
        }
        #endregion

        #region EaseInOutBack
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutBack(float t)
        {
            return EaseInOut(t, EaseInBack, EaseOutBack);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutBack(float t, float d)
        {
            return EaseInOutBack(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutBack(float a, float b, float t)
        {
            return a + (b - a) * EaseInOutBack(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutBack(float a, float b, float t, float d)
        {
            return EaseInOutBack(a, b, t / d);
        }
        #endregion

        #region EaseOutInBack
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInBack(float t)
        {
            return EaseInOut(t, EaseOutBack, EaseInBack);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInBack(float t, float d)
        {
            return EaseOutInBack(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInBack(float a, float b, float t)
        {
            return a + (b - a) * EaseOutInBack(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInBack(float a, float b, float t, float d)
        {
            return EaseOutInBack(a, b, t / d);
        }
        #endregion

        #region EaseInElastic
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInElastic(float t)
        {
            return t != 0F && t != 1F ? -HMath.Pow(2F, 10F * (t -= 1F)) * HMath.Sin((t - 0.3f / 4F) * (2F * HMath.PI) / 0.3f) : t;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInElastic(float t, float d)
        {
            return EaseInElastic(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInElastic(float a, float b, float t)
        {
            return a + (b - a) * EaseInElastic(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInElastic(float a, float b, float t, float d)
        {
            return EaseInElastic(a, b, t / d);
        }
        #endregion

        #region EaseOutElastic
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutElastic(float t)
        {
            return t != 0F && t != 1F ? HMath.Pow(2F, -10F * t) * HMath.Sin((t - 0.3f / 4F) * (2F * HMath.PI) / 0.3f) + 1F : t;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutElastic(float t, float d)
        {
            return EaseOutElastic(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutElastic(float a, float b, float t)
        {
            return a + (b - a) * EaseOutElastic(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutElastic(float a, float b, float t, float d)
        {
            return EaseOutElastic(a, b, t / d);
        }
        #endregion

        #region EaseInOutElastic
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutElastic(float t)
        {
            return EaseInOut(t, EaseInElastic, EaseOutElastic);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutElastic(float t, float d)
        {
            return EaseInOutElastic(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutElastic(float a, float b, float t)
        {
            return a + (b - a) * EaseInOutElastic(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutElastic(float a, float b, float t, float d)
        {
            return EaseInOutElastic(a, b, t / d);
        }
        #endregion

        #region EaseOutInElastic
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInElastic(float t)
        {
            return EaseInOut(t, EaseOutElastic, EaseInElastic);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInElastic(float t, float d)
        {
            return EaseOutInElastic(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInElastic(float a, float b, float t)
        {
            return a + (b - a) * EaseOutInElastic(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInElastic(float a, float b, float t, float d)
        {
            return EaseOutInElastic(a, b, t / d);
        }
        #endregion

        #region EaseInBounce
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInBounce(float t)
        {
            return 1F - EaseOutBounce(1F - t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInBounce(float t, float d)
        {
            return EaseInBounce(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInBounce(float a, float b, float t)
        {
            return a + (b - a) * EaseInBounce(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInBounce(float a, float b, float t, float d)
        {
            return EaseInBounce(a, b, t / d);
        }
        #endregion

        #region EaseOutBounce
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutBounce(float t)
        {
            if (t < 1F / 2.75f)
            {
                return 7.5625f * t * t;
            }
            else if (t < 2F / 2.75f)
            {
                t -= 1.5f / 2.75f;
                return 7.5625f * t * t + 0.75f;
            }
            else if (t < 2.5f / 2.75f)
            {
                t -= 2.25f / 2.75f;
                return 7.5625f * t * t + 0.9375f;
            }
            else
            {
                t -= 2.625f / 2.75f;
                return 7.5625f * t * t + 0.984375f;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutBounce(float t, float d)
        {
            return EaseOutBounce(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutBounce(float a, float b, float t)
        {
            return a + (b - a) * EaseOutBounce(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutBounce(float a, float b, float t, float d)
        {
            return EaseOutBounce(a, b, t / d);
        }
        #endregion

        #region EaseInOutBounce
        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutBounce(float t)
        {
            return EaseInOut(t, EaseInBounce, EaseOutBounce);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutBounce(float t, float d)
        {
            return EaseInOutBounce(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutBounce(float a, float b, float t)
        {
            return a + (b - a) * EaseInOutBounce(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseInOutBounce(float a, float b, float t, float d)
        {
            return EaseInOutBounce(a, b, t / d);
        }
        #endregion

        #region EaseOutInBounce
        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInBounce(float t)
        {
            return EaseInOut(t, EaseOutBounce, EaseInBounce);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInBounce(float t, float d)
        {
            return EaseOutInBounce(t / d);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInBounce(float a, float b, float t)
        {
            return a + (b - a) * EaseOutInBounce(t);
        }

        /// <summary>
        /// 
        /// </summary>
        public static float EaseOutInBounce(float a, float b, float t, float d)
        {
            return EaseOutInBounce(a, b, t / d);
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public static Func<float, float> Get(Functions function)
        {
            switch (function)
            {
                case Functions.Linear: return Linear;
                case Functions.EaseInSine: return EaseInSine;
                case Functions.EaseOutSine: return EaseOutSine;
                case Functions.EaseInOutSine: return EaseInOutSine;
                case Functions.EaseOutInSine: return EaseOutInSine;
                case Functions.EaseInQuad: return EaseInQuad;
                case Functions.EaseOutQuad: return EaseOutQuad;
                case Functions.EaseInOutQuad: return EaseInOutQuad;
                case Functions.EaseOutInQuad: return EaseOutInQuad;
                case Functions.EaseInCubic: return EaseInCubic;
                case Functions.EaseOutCubic: return EaseOutCubic;
                case Functions.EaseInOutCubic: return EaseInOutCubic;
                case Functions.EaseOutInCubic: return EaseOutInCubic;
                case Functions.EaseInQuart: return EaseInQuart;
                case Functions.EaseOutQuart: return EaseOutQuart;
                case Functions.EaseInOutQuart: return EaseInOutQuart;
                case Functions.EaseOutInQuart: return EaseOutInQuart;
                case Functions.EaseInQuint: return EaseInQuint;
                case Functions.EaseOutQuint: return EaseOutQuint;
                case Functions.EaseInOutQuint: return EaseInOutQuint;
                case Functions.EaseOutInQuint: return EaseOutInQuint;
                case Functions.EaseInExp: return EaseInExp;
                case Functions.EaseOutExp: return EaseOutExp;
                case Functions.EaseInOutExp: return EaseInOutExp;
                case Functions.EaseOutInExp: return EaseOutInExp;
                case Functions.EaseInCirc: return EaseInCirc;
                case Functions.EaseOutCirc: return EaseOutCirc;
                case Functions.EaseInOutCirc: return EaseInOutCirc;
                case Functions.EaseOutInCirc: return EaseOutInCirc;
                case Functions.EaseInBack: return EaseInBack;
                case Functions.EaseOutBack: return EaseOutBack;
                case Functions.EaseInOutBack: return EaseInOutBack;
                case Functions.EaseOutInBack: return EaseOutInBack;
                case Functions.EaseInElastic: return EaseInElastic;
                case Functions.EaseOutElastic: return EaseOutElastic;
                case Functions.EaseInOutElastic: return EaseInOutElastic;
                case Functions.EaseOutInElastic: return EaseOutInElastic;
                case Functions.EaseInBounce: return EaseInBounce;
                case Functions.EaseOutBounce: return EaseOutBounce;
                case Functions.EaseInOutBounce: return EaseInOutBounce;
                case Functions.EaseOutInBounce: return EaseOutInBounce;
                default: return Linear;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static float Ease(Functions function, float t)
        {
            return Get(function)(t);
        }

        public static void DrawGizmos(Func<float, float> function, Vector3 position, Vector2 size, Color axis, Color line, int precision = 100)
        {
            Color gizmosColor = Gizmos.color;

            Gizmos.color = axis;
            Gizmos.DrawLine(position, position + Vector3.right * size.x);
            Gizmos.DrawLine(position, position + Vector3.up * size.y);

            Gizmos.color = line;
            Vector3 to, from = position;
            for (int i = 0; i < precision; i++)
            {
                float t = HMath.Clamp01((i + 1F) / precision);

                float d = function(t);

                to = position + new Vector3(t * size.x, d * size.y);

                Gizmos.DrawLine(from, to);

                from = to;
            }

            Gizmos.color = gizmosColor;
        }

        public static void DrawGizmos(Func<float, float> function, Vector3 position, float size, Color axis, Color line, int precision = 100)
        {
            DrawGizmos(function, position, new Vector2(size * 2F, size), axis, line, precision);
        }

        public static void DrawGizmos(Functions function, Vector3 position, Vector2 size, Color axis, Color line, int precision = 100)
        {
            DrawGizmos(Get(function), position, size, axis, line, precision);
        }

        public static void DrawGizmos(Functions function, Vector3 position, float size, Color axis, Color line, int precision = 100)
        {
            DrawGizmos(function, position, new Vector2(size * 2F, size), axis, line, precision);
        }
    }
}