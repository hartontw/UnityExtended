using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityExtended
{
    /// <summary>
    /// 
    /// </summary>
    public class SceneSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        protected static bool IsLocked { get; private set; }

        private static readonly object _lock = new object();
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (IsLocked)
                {
                    Debug.LogWarning(Diagnostics.CallerString + " is trying to access to " + typeof(T) + " instance while the application is quitting.");
                    return null;
                }

                lock (_lock)
                {
                    if (_instance != null)
                        return _instance;

                    _instance = FindObjectOfType<T>();

                    if (_instance == null)
                        Debug.LogError(Diagnostics.CallerString + " is trying to access to " + typeof(T) + " instance but it not exists in the scene.");

                    return _instance;
                }
            }
        }

        public static T _ { get { return Instance; } }

        private void Awake()
        {
            if (!IsLocked)
            {
                bool awake = false;

                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = GetComponent<T>();
                        awake = true;
                    }
                    else if (_instance == GetComponent<T>())
                        awake = true;
                    else
                        Destroy(gameObject);
                }

                if (awake)
                    Initiate();
            }
        }

        private void OnDestroy()
        {
            Terminate();
            _instance = null;
        }

        private void OnApplicationQuit()
        {
            IsLocked = true;
            Terminate();
        }

        protected virtual void Initiate() { }
        protected virtual void Terminate() { }
    }
}