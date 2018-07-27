using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtended
{
    public class CoroutineQueue<T> : ManagedCoroutine where T : ManagedCoroutine, IEnumerator
    {
        private int current = 0;
        private readonly List<T> query = new List<T>();

        public CoroutineQueue(params T[] coroutines) : base()
        {
            this.query.AddRange(coroutines);
        }

        public CoroutineQueue(IEnumerable<T> coroutines) : base()
        {
            this.query.AddRange(coroutines);
        }

        public CoroutineQueue(MonoBehaviour owner, params T[] coroutines) : base(owner)
        {
            this.query.AddRange(coroutines);
        }

        public CoroutineQueue(MonoBehaviour owner, IEnumerable<T> coroutines) : base(owner)
        {
            this.query.AddRange(coroutines);
        }

        public T Coroutine { get { return query[current]; } }

        public override IEnumerator Routine
        {
            get
            {
                while (current < query.Count)
                    yield return query[current++];
            }
        }

        public void Add(params T[] query)
        {
            this.query.AddRange(query);
        }

        public void Add(IEnumerable<T> query)
        {
            this.query.AddRange(query);
        }

        public void Remove(T coroutine)
        {
            this.query.Remove(coroutine);
        }

        public static CoroutineQueue<K> Start<K>(params K[] coroutines) where K : ManagedCoroutine, IEnumerator
        {
            CoroutineQueue<K> queue = new CoroutineQueue<K>(coroutines);
            queue.Start();
            return queue;
        }

        public static CoroutineQueue<K> Start<K>(IEnumerable<K> coroutines) where K : ManagedCoroutine, IEnumerator
        {
            CoroutineQueue<K> queue = new CoroutineQueue<K>(coroutines);
            queue.Start();
            return queue;
        }
    }
}
