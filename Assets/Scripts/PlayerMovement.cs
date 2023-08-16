using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody2D rig;
    Vector2 movement;
    Animator anim;


    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        anim.SetFloat("Speed", movement.sqrMagnitude);
        MoveHero();
        OrientHero();

    }
    public void MoveHero()
    {
        rig.MovePosition(rig.position + movement * speed * Time.fixedDeltaTime);
        anim.Play("Walk");
    }
    public void OrientHero()
    {
        if (movement.x > 0) 
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        else if (movement.x < 0) 
        {
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
    }
}