using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UnityExtended
{
    public class Coroutiner : GameSingleton<Coroutiner>
    {
        private Dictionary<int, HashSet<ManagedCoroutine>> coroutines = new Dictionary<int, HashSet<ManagedCoroutine>>();

        private IEnumerable<T> loop<T>(IEnumerable<T> subgroup, Action<T> action) where T : ManagedCoroutine
        {
            foreach (T coroutine in subgroup)
                action(coroutine);

            return subgroup;
        }

        private void stop<T>(T coroutine) where T : ManagedCoroutine
        {
            coroutine.Stop();
        }

        private void reset<T>(T coroutine) where T : ManagedCoroutine
        {
            coroutine.Stop();
            coroutine.Start();
        }

        public void Handle(MonoBehaviour behaviour, ManagedCoroutine coroutine)
        {
            int code = behaviour.GetHashCode();

            if (!coroutines.ContainsKey(code))
                coroutines.Add(code, new HashSet<ManagedCoroutine>());

            if (!coroutines[code].Contains(coroutine))
            {
                coroutines[code].Add(coroutine);

                Action<ManagedCoroutine> handler = null;
                handler = (c) =>
                {
                    if (behaviour != null)
                    {
                        if (coroutines[code].Contains(c))
                        {
                            coroutines[code].Remove(c);

                            if (coroutines[code].Count == 0)
                                coroutines.Remove(code);
                        }
                    }
                    else coroutines.Remove(code);

                    coroutine.OnFinish -= handler;
                };
            }
        }

        public IEnumerable<T> Get<T>(MonoBehaviour behaviour = null) where T : ManagedCoroutine
        {
            return Get(behaviour).OfType<T>();
        }

        public IEnumerable<ManagedCoroutine> Get(MonoBehaviour behaviour = null)
        {
            if (behaviour == null)
                behaviour = this;

            int code = behaviour.GetHashCode();

            if (coroutines.ContainsKey(code))
                return coroutines[code];

            return null;
        }

        public IEnumerable<ManagedCoroutine> Get(IEnumerator routine)
        {
            return Get().Where(x => x.Routine.Equals(routine));
        }

        public IEnumerable<ManagedCoroutine> Get(MonoBehaviour behaviour, IEnumerator routine)
        {
            return Get(behaviour).Where(x => x.Routine.Equals(routine));
        }

        public IEnumerable<T> GetAll<T>() where T : ManagedCoroutine
        {
            int code = GetHashCode();

            IEnumerable<T> subgroup = coroutines[code].OfType<T>();

            foreach(int key in coroutines.Keys)
            {
                if (key != code)
                    subgroup.Concat(coroutines[key].OfType<T>());
            }

            return subgroup;
        }

        public IEnumerable<ManagedCoroutine> GetAll()
        {
            HashSet<ManagedCoroutine> all = new HashSet<ManagedCoroutine>();

            var values = coroutines.Values;

            foreach (var value in values)
                all.Concat(value);

            return all.AsEnumerable();
        }

        public static IEnumerable<T> Stop<T>(MonoBehaviour behaviour = null) where T : ManagedCoroutine
        {
            return Instance.loop(Instance.Get<T>(behaviour), Instance.stop);
        }

        public static IEnumerable<ManagedCoroutine> Stop(IEnumerator routine)
        {
            return Instance.loop(Instance.Get(routine), Instance.stop);
        }

        public static IEnumerable<ManagedCoroutine> Stop(MonoBehaviour behaviour, IEnumerator routine)
        {
            return Instance.loop(Instance.Get(behaviour, routine), Instance.stop);
        }

        public static IEnumerable<ManagedCoroutine> Stop(Func<ManagedCoroutine, bool> where)
        {
            return Instance.loop(Instance.Get().Where(where), Instance.stop);
        }

        public static IEnumerable<ManagedCoroutine> Stop(MonoBehaviour behaviour, Func<ManagedCoroutine, bool> where)
        {
            return Instance.loop(Instance.Get(behaviour).Where(where), Instance.stop);
        }

        public static IEnumerable<T> Reset<T>(MonoBehaviour behaviour = null) where T : ManagedCoroutine
        {
            return Instance.loop(Instance.Get<T>(behaviour), Instance.reset);
        }

        public static IEnumerable<ManagedCoroutine> Reset(IEnumerator routine)
        {
            return Instance.loop(Instance.Get(routine), Instance.reset);
        }

        public static IEnumerable<ManagedCoroutine> Reset(MonoBehaviour behaviour, IEnumerator routine)
        {
            return Instance.loop(Instance.Get(behaviour, routine), Instance.reset);
        }

        public static IEnumerable<ManagedCoroutine> Reset(Func<ManagedCoroutine, bool> where)
        {
            return Instance.loop(Instance.Get().Where(where), Instance.reset);
        }

        public static IEnumerable<ManagedCoroutine> Reset(MonoBehaviour behaviour, Func<ManagedCoroutine, bool> where)
        {
            return Instance.loop(Instance.Get(behaviour).Where(where), Instance.reset);
        }
    }
}