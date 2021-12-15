using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FG
{
    [CreateAssetMenu]
    public class Genericevent : ScriptableObject
    {
        private List<Genericeventlistener> listeners;

        public void Raise()
        {
            foreach (Genericeventlistener each in listeners)
                each.Oneventraised();
        }

        public void Register(Genericeventlistener listener)
        {
            listeners.Add(listener);
        }

        public void Unregister(Genericeventlistener listener)
        {
            listeners.Remove(listener);
        }

        private void OnApplicationQuit()
        {
            listeners.Clear();
        }
    }
}