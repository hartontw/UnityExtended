using System;
using System.Collections;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Process : CustomYieldInstruction
    {
        public Action<Process> OnStateChange;

        private EProcess state;
        public EProcess State
        {
            get { return state; }
            protected set
            {
                state = value;

                if (state != EProcess.Waiting)
                {
                    if (state == EProcess.Running)
                        StartTime = Time.time;
                    else
                        EndTime = Time.time;
                }

                if (OnStateChange != null)
                    OnStateChange(this);

                StateChange();
            }
        }

        public bool IsRunning { get { return state == EProcess.Running; } }

        public bool IsFinished { get { return state == EProcess.Finished; } }

        public float StartTime { get; private set; }

        public float EndTime { get; private set; }

        public float RunningTime
        {
            get
            {
                switch (State)
                {
                    case EProcess.Waiting: return 0F;
                    case EProcess.Running: return Time.time - StartTime;
                    default: return EndTime - StartTime;
                }
            }
        }

        public override bool keepWaiting { get { return IsRunning; } }

        public abstract void Start();
        public abstract void Stop();

        protected abstract void StateChange();
    }

    /// <summary>
    /// 
    /// </summary>
    public abstract class Process<T> : Process where T : Process<T>
    {
        public Action<T> OnStart;
        public Action<T> OnFinish;

        protected override void StateChange()
        {
            if (State != EProcess.Waiting)
            {
                if (State == EProcess.Running)
                {
                    if (OnStart != null)
                        OnStart((T)this);
                }
                else
                {
                    if (OnFinish != null)
                        OnFinish((T)this);
                }
            }
        }
    }
}
