using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityExtended
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ManagedCoroutine : Process<ManagedCoroutine>
    {
        public readonly MonoBehaviour behaviour;
        public abstract IEnumerator Routine { get; }

        private Coroutine coroutine;
        private Coroutine launcher;

        public string Info { get; protected set; }

        public ManagedCoroutine()
        {
            Info = behaviour.name + ": " + GetType() + " is waiting.";
            this.behaviour = Coroutiner.Instance;
        }

        public ManagedCoroutine(MonoBehaviour behaviour)
        {
            Info = behaviour.name + ": " + GetType() + " is waiting.";
            this.behaviour = behaviour ?? Coroutiner.Instance;
        }

        public override void Start()
        {
            if (!IsRunning)
            {
                if (behaviour == null)
                {
                    Info = "Pad Behaviour of this coroutine is null.";
                    Debug.LogWarning(Info);
                    State = EProcess.Failed;
                }
                else
                {
                    launcher = behaviour.StartCoroutine(IStart());
                    Coroutiner.Instance.Handle(behaviour, this);
                }
            }
            else
            {
                Info = behaviour.name + ": " + GetType() + " is already " + State;
                Debug.LogWarning(Info);
            }
        }

        private IEnumerator IStart()
        {
            Info = behaviour.name + ": " + GetType() + " is running.";

            State = EProcess.Running;

            coroutine = behaviour.StartCoroutine(Routine);
            yield return coroutine;

            Info = behaviour.name + ": " + GetType() + " is finished.";

            State = EProcess.Finished;
        }

        public override void Stop()
        {
            if (IsRunning)
            {
                Info = behaviour.name + ": " + GetType() + " is stopped.";
                behaviour.StopCoroutine(launcher);
                behaviour.StopCoroutine(coroutine);
                State = EProcess.Stopped;
            }
            else
            {
                Info = behaviour.name + ": " + GetType() + " is already " + State;
                Debug.LogWarning(Info);
            }
        }
    }
}