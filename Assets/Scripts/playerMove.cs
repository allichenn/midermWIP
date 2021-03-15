using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMove : MonoBehaviour
{
    /*[SerializedField]*/
    public float moveSpeed;
    public Rigidbody2D rb;
    public Text keyText;
    public Text endText;
    
    bool redRiddle = true;
    bool orangeRiddle = false;
    bool yellowRiddle = false;
    bool greenRiddle = false;
    bool homeRiddle = false;


    bool eggActive = false;
    bool carrotActive = false;
    bool watermelonActive = false;
    bool donutActive = false;
    //bool homeActive = false;

    public GameObject exclaimationPoint, exclaimationPoint2, object1;
    public Transform pointOne, pointTwo, pointThree;

    //float objX = transform.position.x;

    Vector3 movement;

    //inclass stuff is below
    private bool reachedPos = true;
    private bool stopMovement = false;
    private Vector3 nextPos;
    private bool hitItem = false;

    public float sightDist;
    Animator myAnim;

    bool hitRed, hitOrange, hitYellow, hitGreen;

    // Start is called before the first frame update
    void Start()
    {
        exclaimationPoint2.SetActive(false);
        myAnim = gameObject.GetComponent<Animator>();
    }

    void Update(){
        RaycastHit2D hit = Physics2D.Raycast(transform.position, movement, sightDist);
        Debug.DrawRay(transform.position, movement, Color.red);
        if(hit.collider != null){
            //Debug.Log("hit npc");
            if(hit.collider.tag == "red"){
                Debug.Log("hit red");
                exclaimationPoint.SetActive(false);
                exclaimationPoint.transform.position = pointOne.position;
                hitRed = true;
            } else if(hit.collider.tag == "orange"){
                Debug.Log("hit orange");
                exclaimationPoint.SetActive(true);
                exclaimationPoint.transform.position = pointTwo.position;
                hitOrange = true;
            } else if(hit.collider.tag == "yellow"){
                Debug.Log("hit yellow");
                exclaimationPoint.SetActive(true);
                exclaimationPoint.transform.position = pointThree.position;
                hitYellow = true;
            } else if(hit.collider.tag == "green"){
                Debug.Log("hit green");
                hitGreen = true;
            } else {
                hitItem = false;
                hitOrange = false;
                hitYellow = false;
                hitGreen = false;
            }
        }


        /*if(Input.GetMouseButtonDown(0)){
            StartMovement();
        }*/

        /*if(!reachedPos){
            transform.position = Vector2.MoveTowards(transform.position, nextPos, speed);
            if(Vector3.Distance(transform.position, nextPos) <= 1f){
                reachedPos = true;
            }
        }*/
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movementInput();
        rb.velocity = movement * moveSpeed;
    }

    /*void StartMovement(){
        nextPos = Input.mousePosition;
        nextPos = Camera.main.ScreenToWorldPoint(nextPos);
        nextPos.z = 0;
        reachedPos = false;
        Debug.Log(nextPos);
    }*/

    void movementInput(){
        float mx = Input.GetAxisRaw("Horizontal");
        float my = Input.GetAxisRaw("Vertical");

        movement = new Vector3(mx, my).normalized;

        /*if (movement.x > 0.2f || movement.x <= -0.2){
            myAnim.SetBool("goingSide", true);
        } else {
            if (movement.y > 0){
                myAnim.SetBool("goingUp", true);
            } else {
                myAnim.SetBool("goingDown", true);
            }
        }*/
    }



    private void OnCollisionStay2D(Collision2D other){
        
        if(other.gameObject.name == "red_0" && redRiddle == true){
            if (Input.GetKey(KeyCode.Space)){
                keyText.text = "A BOX WITHOUT HINGES, LOCK OR KEY, \nYET A GOLDEN TREASURE LIES INSIDE ME. \nGO FIND IT FOR ME!";
                exclaimationPoint.SetActive(false);
                exclaimationPoint.transform.position = pointOne.position;
                Debug.Log("touched red, bools redRiddle:" + redRiddle + " orangeRiddle: " + orangeRiddle);
                eggActive = true;
            }
        } else if(other.gameObject.name == "egg1" && eggActive == true){
            if (Input.GetKey(KeyCode.Space)){
                keyText.text = "CORRECT, AN EGG! THANK YOU!\n\nSEEMS LIKE ORANGE (BOTTOM LEFT) NEEDS SOME HELP TOO.";
                Debug.Log("found egg");
                Destroy(other.gameObject);
                exclaimationPoint.SetActive(true);
                redRiddle = false;
                eggActive = false;
                orangeRiddle = true;
            }
        } else if(other.gameObject.name == "orange_0" && orangeRiddle == true){
            if (Input.GetKey(KeyCode.Space)){
                keyText.text = "HELP ME FIND SOMETHING THAT IS \nORANGE AND SOUNDS LIKE PARROT!";
                exclaimationPoint.SetActive(false);
                Debug.Log("touched orange");
                carrotActive = true;
            }
        } else if(other.gameObject.name == "carrot1" && carrotActive == true){
            if (Input.GetKey(KeyCode.Space)){
                keyText.text = "YES, A CARROT! JUST WHAT I NEEDED!\n\nTALK TO YELLOW (BOTTOM RIGHT) NEXT?";
                Debug.Log("found carrot");
                Destroy(other.gameObject);
                exclaimationPoint2.SetActive(true);
                orangeRiddle = false;
                carrotActive = false;
                yellowRiddle = true;
            }
        } else if(other.gameObject.name == "yellow_0" && yellowRiddle == true){
            if (Input.GetKey(KeyCode.Space)){
                keyText.text = "IT LOOKS GREEN, IT OPENS RED. \nWHAT YOU EAT IS RED BUT \nWHAT YOU SPIT OUT IS BLACK. \nWHAT AM I LOOKING FOR?";
                exclaimationPoint2.SetActive(false);
                exclaimationPoint2.transform.position = pointThree.position;
                Debug.Log("touched yellow");
                watermelonActive = true;
            }
        } else if(other.gameObject.name == "watermelon1" && watermelonActive == true){
            if (Input.GetKey(KeyCode.Space)){
                keyText.text = "YES, A SLICE OF WATERMLON! YUM!\n\nPLEASE HELP GREEN (TOP RIGHT) AND CALL IT A DAY!";
                Debug.Log("found watermelon");
                Destroy(other.gameObject);
                exclaimationPoint2.SetActive(true);
                yellowRiddle = false;
                watermelonActive = false;
                greenRiddle = true;
            }
        } else if(other.gameObject.name == "green_0" && greenRiddle == true){
            if (Input.GetKey(KeyCode.Space)){
                keyText.text = "WHAT I AM LOOKING FOR HAS NO\nBEGINNING, MIDDLE, OR END.";
                exclaimationPoint2.SetActive(false);
                Debug.Log("touched green");
                donutActive = true;
            }
        } else if(other.gameObject.name == "donut1" && donutActive == true){
            if (Input.GetKey(KeyCode.Space)){
                keyText.text = "INDEED, IT IS A DONUT!\n\nTHANK YOU SO MUCH FOR YOUR HELP! \nIT'S GETTING LATE... YOU SHOULD HEAD HOME NOW.";
                Debug.Log("found donut");
                Destroy(other.gameObject);
                greenRiddle = false;
                donutActive = false;
                homeRiddle = true;
            }
        } else if(other.gameObject.name == "homeDoor" && homeRiddle == true){
                endText.text = "IT HAS BEEN A GOOD DAY.\nTHE END.";
                Debug.Log("returned home");
                gameObject.SetActive(false);
                homeRiddle = true;
        } 
    } 
}
