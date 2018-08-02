using System;
using System.Collections;
using UnityEngine;

namespace UnityExtended
{
    public class PeriodicalCoroutine : UpdateCoroutine<int>
    {
        public override IEnumerator Routine
        {
            get
            {
                float elapsed, last = Time.time;
                while (!escapeCondition())
                {
                    elapsed = Time.time - last;
                    if (elapsed > frequency)
                    {
                        action(++cicles);
                        last = Time.time - (elapsed - frequency);
                    }

                    yield return base.Routine;
                }
            }
        }

        private readonly Func<bool> escapeCondition;
        public readonly float frequency;
        public int cicles { get; private set; }

        public PeriodicalCoroutine(float frequency, Action<int> action, Func<bool> escapeCondition = null) : base()
        {
            this.frequency = frequency;
            this.action = action;
            this.escapeCondition = escapeCondition ?? (() => { return true; });
        }

        public PeriodicalCoroutine(MonoBehaviour behaviour, float frequency, Action<int> action, Func<bool> escapeCondition = null) : base(behaviour)
        {
            this.frequency = frequency;
            this.action = action;
            this.escapeCondition = escapeCondition ?? (() => { return true; });
        }

        public PeriodicalCoroutine(float frequency, int cicles, Action<int> action) : base()
        {
            this.frequency = frequency;
            this.action = action;
            this.escapeCondition = () => { return this.cicles >= cicles; };
        }

        public PeriodicalCoroutine(MonoBehaviour behaviour, float frequency, int cicles, Action<int> action) : base(behaviour)
        {
            this.frequency = frequency;
            this.action = action;
            this.escapeCondition = () => { return this.cicles >= cicles; };
        }

        public PeriodicalCoroutine(float frequency, float duration, Action<int> action) : base()
        {
            this.frequency = frequency;
            this.action = action;
            this.escapeCondition = () => { return this.cicles * frequency >= duration; };
        }

        public PeriodicalCoroutine(MonoBehaviour behaviour, float frequency, float duration, Action<int> action) : base(behaviour)
        {
            this.frequency = frequency;
            this.action = action;
            this.escapeCondition = () => { return this.cicles * frequency >= duration; };
        }
    }
}