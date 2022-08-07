using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCollected : MonoBehaviour
{
  
   public CollectCheck obj;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Player")
     {
         obj.num++;
        
         Destroy(this.gameObject);
     }
    }
}
