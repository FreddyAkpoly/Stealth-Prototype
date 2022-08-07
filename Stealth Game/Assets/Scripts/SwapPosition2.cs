using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapPosition2 : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {     
        MoveGameObject();
    }
    
    public void MoveGameObject()
    {
     transform.position = transform.position + new Vector3(-4, 0, 0);
    }
   
}
