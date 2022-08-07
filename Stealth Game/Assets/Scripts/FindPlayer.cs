using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayer : MonoBehaviour
{

    public float radius = 5f;
   [Range(1,360)]public float angle = 45f;
    public LayerMask targerLayer;
    public LayerMask obsLayer;
    public Animator animator;
   
   public GameObject playerRef;

   public bool CanSeePlayer{get; private set;}

    // Start is called before the first frame update
    void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine (FOVRoutine());
    }

    // Update is called once per frame
    void Update()
    {

      
    } 

    private IEnumerator FOVRoutine(){
        WaitForSeconds wait = new WaitForSeconds(0.2f);

        while(true){
            yield return wait;
            FieldOfViewCheck();
        }
    }

    private void FieldOfViewCheck()
    {
        Collider2D[] rangeCheck = Physics2D.OverlapCircleAll(transform.position, radius, targerLayer);
        if(rangeCheck.Length>0)
        {
            Transform target = rangeCheck[0].transform;
            Vector2 directionToTarget = (target.position - transform.position).normalized;

            if(Vector2.Angle(transform.right * -1, directionToTarget)< angle/2)
            {
                float distanceToTarget = Vector2.Distance(transform.position,target.position);
                if(!Physics2D.Raycast(transform.position,directionToTarget,distanceToTarget,obsLayer)){
                    CanSeePlayer = true;
                     animator.SetBool("Seen",true);
            }
                    else  {
                    CanSeePlayer = false;
                     animator.SetBool("Seen",false);
            }
                }
                else   {
                     CanSeePlayer = false;
                      animator.SetBool("Seen",false);
                }

            }
            else if(CanSeePlayer){
                 CanSeePlayer = false;
                  animator.SetBool("Seen",false);
            }

        }

        private void OnDrawGizmos(){
            Gizmos.color = Color.white;
            UnityEditor.Handles.DrawWireDisc(transform.position, Vector3.forward, radius);

            if(transform.rotation.y < 0){
                    Vector3 angle01 = DirFromAngle(-transform.eulerAngles.z,angle*3);
                    Vector3 angle02 = DirFromAngle(-transform.eulerAngles.z,angle);
                     Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position,transform.position+angle01 * radius);
             Gizmos.DrawLine(transform.position,transform.position+angle02 * radius);
             if(CanSeePlayer){
                 Gizmos.color = Color.green;
                 Gizmos.DrawLine(transform.position,playerRef.transform.position);
             }
            }
            else{
            Vector3 angle01 = DirFromAngle(-transform.eulerAngles.z,-angle*3);
            Vector3 angle02 = DirFromAngle(-transform.eulerAngles.z,-angle);
             Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position,transform.position+angle01 * radius);
             Gizmos.DrawLine(transform.position,transform.position+angle02 * radius);
             if(CanSeePlayer){
                 Gizmos.color = Color.green;
                 Gizmos.DrawLine(transform.position,playerRef.transform.position);
             }
            }

            
           
        }

        private Vector2 DirFromAngle(float eulerY, float angleInDegrees){
            angleInDegrees += eulerY;
            return new Vector2(Mathf.Sin(angleInDegrees*Mathf.Deg2Rad), Mathf.Cos(angleInDegrees* Mathf.Deg2Rad));
        }

    }
