using System;
using UnityEngine;

namespace AnastasyaD
{
    public class Movement : MonoBehaviour
    {
        public float speedRotation = 2f;
        private void FixedUpdate()
        {
            float moveHoris = Input.GetAxis("Horizontal");
            float moveHVert = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHVert, 0.0f,moveHoris);
            transform.Rotate(movement * (speedRotation * Time.deltaTime));
        }
    }
}