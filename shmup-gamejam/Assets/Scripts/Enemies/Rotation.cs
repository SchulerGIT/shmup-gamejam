using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shmup
{
    public class Rotation : MonoBehaviour
    {
        public float RotSpeed = 1f;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

            
            transform.Rotate(0f, 0f, RotSpeed, Space.Self);
        }
    }
}
