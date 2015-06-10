using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    public class Won : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
				Application.LoadLevel("Won");
            }
        }
    }
}
