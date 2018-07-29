using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UnityExtended
{
    public static partial class Extensions
    {
        public static LerpCoroutine<Vector3> SetPosition(this Transform self, Vector3 position, float duration)
        {
            LerpCoroutine<Vector3> coroutine = new LerpCoroutine<Vector3>(duration,
                new Vector3Range(self.position, position),
                (l) => { if (self) self.position = l; }
            );
            coroutine.Start();
            return coroutine;
        }

        public static LerpCoroutine<Vector3> Translate(this Transform self, Vector3 translation, float duration)
        {
            return self.SetPosition(self.position + translation, duration);
        }

        public static LerpCoroutine<Vector3> SetLocalPosition(this Transform self, Vector3 position, float duration)
        {
            LerpCoroutine<Vector3> coroutine = new LerpCoroutine<Vector3>(duration,
                new Vector3Range(self.localPosition, position),
                (l) => { if (self) self.localPosition = l; }
            );
            coroutine.Start();
            return coroutine;
        }

        public static void SetScale(this Transform self, Vector3 scale)
        {
            if (self.parent)
            {
                Vector3 parent = self.parent.lossyScale;
                scale = new Vector3(scale.x / parent.x, scale.y / parent.y, scale.z / parent.z);
            }

            self.localScale = scale;
        }

        public static LerpCoroutine<Vector3> SetScale(this Transform self, Vector3 scale, float duration)
        {
            LerpCoroutine<Vector3> coroutine = new LerpCoroutine<Vector3>(duration,
                new Vector3Range(self.lossyScale, scale),
                (l) => { if (self) self.SetScale(l); }
            );
            coroutine.Start();
            return coroutine;
        }

        public static LerpCoroutine<Vector3> SetLocalScale(this Transform self, Vector3 scale, float duration)
        {
            LerpCoroutine<Vector3> coroutine = new LerpCoroutine<Vector3>(duration,
                new Vector3Range(self.localScale, scale),
                (l) => { if (self) self.localScale = l; }
            );
            coroutine.Start();
            return coroutine;
        }

        public static LerpCoroutine<Quaternion> SetRotation(this Transform self, Quaternion rotation, float duration, bool slerp = true)
        {
            QuaternionRange range = new QuaternionRange(self.rotation, rotation);
            LerpCoroutine<Quaternion> coroutine;
            if (slerp)
            {
                coroutine = new LerpCoroutine<Quaternion>(coroutine, range,
                    (l) => coroutine.InterpolatedValue)
            }
            else
            {
                coroutine = new LerpCoroutine<Quaternion>(duration, range,
                    (l) => { if (self) self.rotation = l; }
                );
                coroutine.Start();
                return coroutine;
            }
        }
    }
}