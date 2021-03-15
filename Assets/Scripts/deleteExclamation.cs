using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deleteExclamation : MonoBehaviour
{
        public Text keyText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void OnTriggerEnter2D(Collider2D other){ //COLLIDER not COLLISION bc no physics
        if(other.gameObject.name == "player"){ //must be double ==
            Destroy(gameObject);
            
            Debug.Log("deleted!");
        }

    }*/

    /*void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "player"){
            Destroy(gameObject);
            keyText.text = "";
            Debug.Log("deleted!");
        }
    }*/
}
