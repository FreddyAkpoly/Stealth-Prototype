using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCheck : MonoBehaviour
{
    public GameObject[] colletibles;
    public int num = 0; 
    public bool collected;
    void Start()
    {
        collected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(num == colletibles.Length){
            collected = true;
               
        }
    }
}
