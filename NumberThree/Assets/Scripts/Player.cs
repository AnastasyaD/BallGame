using UnityEngine;
using UnityEngine.Serialization;


namespace AnastasyaD
{
public class Player : MonoBehaviour
{

    [SerializeField]private float speed = 2;
    private Vector3 _direction = Vector3.zero;

    protected Player(float speed)
    {
        throw new System.NotImplementedException();
    }

    private void Update()
    {
        _direction.x = -Input.GetAxis("Horizontal");
        _direction.z = -Input.GetAxis("Vertical");

        transform.position += _direction * (Time.deltaTime *speed);
    }
}

}
