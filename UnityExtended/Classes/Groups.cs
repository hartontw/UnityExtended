using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExtended
{
    public struct Group<T, K>
    {
        public T v0;
        public K v1;

        public Group(T v0, K v1)
        {
            this.v0 = v0;
            this.v1 = v1;
        }
    }

    public struct Group<T, K, H>
    {
        public T v0;
        public K v1;
        public H v2;

        public Group(T v0, K v1, H v2)
        {
            this.v0 = v0;
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
