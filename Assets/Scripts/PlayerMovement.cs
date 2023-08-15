using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody2D rig;
    public float mapWidth;
    Vector2 movement;
 

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");       
        rig.MovePosition(rig.position + movement * speed * Time.fixedDeltaTime);
    }
}