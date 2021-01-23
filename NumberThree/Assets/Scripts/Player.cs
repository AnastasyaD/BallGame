using UnityEngine;


namespace AnastasyaD
{
public class Player : MonoBehaviour
{

    [SerializeField]private float speedRotation = 10f;
    
    protected Player()
    {
        throw new System.NotImplementedException();
    }

    protected void Move()
    {
        float moveHoris = -Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveVert, 0.0f,moveHoris);
        transform.Rotate(movement * (speedRotation * Time.deltaTime));
    }
}

}
