using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehavior : MonoBehaviour
{

    public float speed;
    //public float jumpHeight;

    Rigidbody2D myBody;
    BoxCollider2D myCollider;

    float moveDir = 1;
    float moveXDir = 1;

    // Start is called before the first frame update
    void Start()
    {
        myBody = gameObject.GetComponent<Rigidbody2D>();
        myCollider = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void FixedUpdate(){
        CheckKeys();
        HandleMovement();
    }

    void CheckKeys(){
        if(Input.GetKey(KeyCode.D)){
            moveDir = 1;
        } else if(Input.GetKey(KeyCode.A)){
            moveDir = -1;
        } else if(Input.GetKey(KeyCode.W)){
            moveXDir = 1;
        } else if(Input.GetKey(KeyCode.S)){
            moveXDir = -1;
        } else {
            moveDir = 0;
        }

        /*if(Input.GetKey(KeyCode.W)){
            myBody.velocity = new Vector3(myBody.velocity.x, jumpHeight);
        } */
    }

    void HandleMovement(){
        myBody.velocity = new Vector3(moveDir * speed, myBody.velocity.y);
        myBody.velocity = new Vector3(moveXDir * speed, myBody.velocity.x);
    }

}

