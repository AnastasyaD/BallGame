using UnityEngine;


namespace AnastasyaD
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] private Transform ballTransform;
        void Update()
        {
            var position = ballTransform.position;
            Vector3 newCameraPos = new Vector3
            {
                x = position.x+ 1f,
                y = position.y + 0.5f,
                z = position.z
            };
            this.transform.position = newCameraPos;
        }

    }
}