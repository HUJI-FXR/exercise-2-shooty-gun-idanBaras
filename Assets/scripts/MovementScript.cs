using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float horizontalSpeed;
    [SerializeField] private float verticalSpeed;
    private float rightRot = 180f;
    private float leftRot = 0f;
    private float negative = -1f;
    // Start is called before the first frame update
    
    public void moveRight() 
    {
        gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x,rightRot, gameObject.transform.eulerAngles.z);
        rb.velocity = new Vector2(horizontalSpeed,rb.velocity.y);
    }
    public void moveLeft()
    {
        gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, leftRot, gameObject.transform.eulerAngles.z);
        rb.velocity = new Vector2(negative*horizontalSpeed, rb.velocity.y);
    }

    public void jump() 
    {
        rb.AddForce(Vector2.up*verticalSpeed, ForceMode2D.Impulse);
    }
}
