using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FG
{
    public class Rendercheck : MonoBehaviour
    {
        [SerializeField] private Genericevent thisevent;

        private void OnBecameInvisible()
        {
            thisevent.Raise();
        }
    }
}