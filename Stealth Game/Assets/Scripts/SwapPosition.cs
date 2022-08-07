using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapPosition : MonoBehaviour
{


 
    // Start is called before the first frame update
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
     transform.position = transform.position + new Vector3(4, 0, 0);
    }
   
}
