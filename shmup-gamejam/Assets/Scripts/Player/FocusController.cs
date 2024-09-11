using UnityEngine;
using System.Collections;

namespace Shmup
{
    public class FocusController : MonoBehaviour
    {
        public float slowdownFactor;

        void Update()
        {
            if (Input.GetKey("space") == true)
            {
                Debug.Log("Focused");
                Time.timeScale = slowdownFactor;
                Time.fixedDeltaTime = Time.timeScale * .02f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }
}
