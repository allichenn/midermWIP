using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movePlayer : MonoBehaviour
{

    public Text keyText;
    public float speed; 

    public bool facingRight;
 
    public float horizontalValue;

    // Start is called before the first frame update
    void Start() //create
    {
        
    }

    // Update is called once per frame
     void Update()
    {

        //transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, 0f);
        checkKey();

        //flip char
        /*Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0){
            characterScale.x = 1;
        }

        if (Input.GetAxis("Horizontal") > 0){
            characterScale.x = -1;
        }

        transform.localScale = characterScale;*/
    }
    
    void checkKey(){

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(Vector3.up * Time.deltaTime * speed); //takes one parameter: direction, time between each frame
            Debug.Log("W key pressed");
            //keyText.text = "w key pressed";
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(Vector3.down * Time.deltaTime * speed); 
            Debug.Log("S key pressed");
            //keyText.text = "s key pressed";
        } else if (Input.GetKey(KeyCode.A)){
            transform.Translate(Vector3.left * Time.deltaTime * speed); 
            //horizontalValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            Debug.Log("A key pressed");
            //keyText.text = "a key pressed";
        } else if (Input.GetKey(KeyCode.D)){
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            //transform.Rotate(new Vector3(0, 180, 0)); 
            //horizontalValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            Debug.Log("D key pressed");
            //keyText.text = "d key pressed";
        } else {
            Debug.Log("no key pressed");
            //keyText.text = "no key pressed";
        }

    }
}
