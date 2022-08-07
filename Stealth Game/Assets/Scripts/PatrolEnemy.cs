using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
 
    public float speed;
    public Transform[] patrolPoints;
    public float waitTime;
    int currentPointIndex; 
    

    bool once; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(transform.position.x != patrolPoints[currentPointIndex].position.x){
            transform.position = Vector2.MoveTowards(transform.position,patrolPoints[currentPointIndex].position, speed * Time.deltaTime );
        }else{
            if(once == false){
                once = true;
                StartCoroutine(Wait());
            }
           
        }
    }

    IEnumerator Wait(){

        yield return new WaitForSeconds(waitTime);
        if(currentPointIndex+1<patrolPoints.Length){
             currentPointIndex++;
            transform.Rotate(new Vector3(0,180,0));
           
        }else{
            currentPointIndex = 0;
            transform.Rotate(new Vector3(0,180,0));
        }
       once = false;
    }
}
