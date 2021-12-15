using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FG
{
    public class Genericeventlistener : MonoBehaviour
    {
        [SerializeField] private Genericevent thisevent;
        [SerializeField] private Camera cam;

        public void Oneventraised()
        {
            Vector3 screenpoint = cam.WorldToScreenPoint(transform.position);
            screenpoint = new Vector3(Screenwrap(screenpoint.x, cam.pixelWidth), Screenwrap(screenpoint.y, cam.pixelHeight), screenpoint.z);
            transform.position = cam.ScreenToWorldPoint(screenpoint);
        }

        private float Screenwrap(float pos, float maxdist)
        {
            pos %= maxdist;
            return pos < 0 ? pos + maxdist : pos;
        }

        private void Awake()
        {
            thisevent.Register(this);
        }

        private void OnApplicationQuit()
        {
            thisevent.Unregister(this);
        }
    }
}