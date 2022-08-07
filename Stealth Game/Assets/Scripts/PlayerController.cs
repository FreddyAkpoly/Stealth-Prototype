using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{

//Movement
    public float speed;
    public float jump;
    float moveVelocity;

     public Animator animator;

    //Grounded Vars
   public bool grounded = true;

   void Start(){
   
   }

    void Update () 
    {
        //Jumping
        if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.Z) || Input.GetKeyDown (KeyCode.W)) 
        {
            if(grounded)
            {
                GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jump);
            }
        }

      
         animator.SetFloat("Speed",moveVelocity);
       
         moveVelocity = 0;
        //Left Right Movement
        if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) 
        {
            moveVelocity = -speed;
            
        }
        if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) 
        {
            moveVelocity = speed;
        
        }

        GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);

    }
    //Check if Grounded
     void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "ground")
     {
         grounded = true;
     }
       
    }
    void OnTriggerExit2D(Collider2D target)
    {
        if(target.tag == "ground")
     {
         grounded = false;
     }
    }
}