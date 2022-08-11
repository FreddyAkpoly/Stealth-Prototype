using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DoorState : MonoBehaviour
{
    // Start is called before the first frame update
    
    public CollectCheck checkCollect; 
     SpriteRenderer sprite;
     public bool entered = false;
    void Start()
    {
       
         sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(checkCollect.collected){
            
             sprite.color = new Color (0, 1, 0, 1); 
        }

    }

    void gameEnd(){
       // UnityEditor.EditorApplication.isPlaying = false;
       entered = true; 
        
    }

    void OnTriggerStay2D(Collider2D target)
    {
       
         if(checkCollect.collected){
            if(Input.GetKey (KeyCode.E)){
                   
                    Debug.Log("END");
                     gameEnd();
            }
               
         
     }
       
    }


}
