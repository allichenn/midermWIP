using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScroll : MonoBehaviour
{

    public Text keyText;
    //bool redRiddle = true;
    //bool orangeRiddle = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
/*
    void OnTriggerEnter2D(Collider2D other){ //COLLIDER not COLLISION bc no physics
        if(other.gameObject.name == "player" && redRiddle == true){ //must be double ==
            keyText.text = "A BOX WITHOUT HINGES, LOCK OR KEY, \nYET A GOLDEN TREASURE LIES INSIDE ME. \nGO FIND IT FOR ME!";
            Debug.Log("touched red");
            orangeRiddle = true;
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "player"){
            keyText.text = "HELP ME FIND SOMETHING THAT IS \nORANGE AND SOUNDS LIKE PARROT!";
        }
    }*/
}
