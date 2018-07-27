using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UnityExtended
{
    public class QuaternionRange : InterpolableRange<Quaternion>
    {
        public QuaternionRange(Quaternion min, Quaternion max) : base(min, max) { }

        public override Quaternion Lerp(float t)
        {
            return Quaternion.Lerp(min, max, t);
        }

        public Quaternion Slerp(float t)
        {
            return Quaternion.Slerp(min, max, t);
        }
    }
}
