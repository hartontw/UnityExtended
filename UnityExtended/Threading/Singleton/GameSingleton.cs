using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityExtended
{
    /// <summary>
    /// 
    /// </summary>
    public class GameSingleton<T> : MonoBehaviour where T : MonoBehaviour
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
                    {
                        GameObject go = new GameObject();
                        go.name = typeof(T).ToString();
                        DontDestroyOnLoad(go);
                        _instance = go.AddComponent<T>();
                    }

                    return _instance;
                }
            }
        }

        public static T _ { get { return Instance; } }

        private void Awake()
        {
            if (!IsLocked)
            {
                bool init = false;

                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = GetComponent<T>();
                        init = true;
                    }
                    else if (_instance == GetComponent<T>())
                        init = true;
                    else
                        Destroy(gameObject);
                }

                if (init)
                    Initiate();
            }
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