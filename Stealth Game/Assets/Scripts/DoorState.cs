using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorState : MonoBehaviour
{
    // Start is called before the first frame update
    
    public CollectCheck checkCollect; 
     SpriteRenderer sprite;
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
}
