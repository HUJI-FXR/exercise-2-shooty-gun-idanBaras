using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    MovementScript mv;
    bool grounded = false;
    [SerializeField] string groundTag;
    [SerializeField] string moveRightButton;
    [SerializeField] string moveLeftButton;
    [SerializeField] string moveUpButton;
    // Start is called before the first frame update
    void Start()
    {
        mv = GetComponent<MovementScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveRightButton))
        {
            mv.moveRight();
        }
        else {
            if (Input.GetKey(moveLeftButton)) {
                mv.moveLeft();
            }
        }
        
        if(Input.GetKey(moveUpButton) && grounded)
        {
            mv.jump();
            grounded = false;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == groundTag)
        {
            grounded = true;
        }
    }
    

}
