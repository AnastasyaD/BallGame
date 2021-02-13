using UnityEngine;


namespace AnastasyaD
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] private Transform ballTransform;
        [SerializeField] private float yPosition = 1.0f;
        [SerializeField] private float xPosition = 0.5f;
        void Update()
        {
            var position = ballTransform.position;
            Vector3 newCameraPos = new Vector3
            {
                x = position.x+ xPosition,  
                y = position.y + yPosition,
                z = position.z
            };
            transform.position = newCameraPos;
        }
    }
}