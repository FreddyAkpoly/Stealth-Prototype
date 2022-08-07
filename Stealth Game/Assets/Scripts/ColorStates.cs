using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorStates : MonoBehaviour
{
    SpriteRenderer sprite;
   
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Alpha1))
        {            
            // Change the 'color' property of the 'Sprite Renderer'
            sprite.color = new Color (0, 0, 0, 1); 
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {            
            // Change the 'color' property of the 'Sprite Renderer'
            sprite.color = new Color (1, 0, 0, 1);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {            
            // Change the 'color' property of the 'Sprite Renderer'
            sprite.color = new Color (0, 0, 1, 1); 
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {            
            // Change the 'color' property of the 'Sprite Renderer'
            sprite.color = new Color (0, 1, 0, 1); 
        }
       
    }
}
