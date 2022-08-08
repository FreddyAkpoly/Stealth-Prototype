using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeenMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject menu; // Assign in inspector
   public GameObject WinMenu;
    public bool isShowing;
     public FindPlayer seen; 
     public DoorState entered; 

     void start(){
         menu.SetActive(isShowing);
     }
 
     void FixedUpdate() {
         if (seen.CanSeePlayer) {
             isShowing = !isShowing;
             menu.SetActive(isShowing);
             Time.timeScale = 0;
         }
         else if(entered.entered){
            isShowing = !isShowing;
             WinMenu.SetActive(isShowing);
                Time.timeScale = 0;
         }
     }
}
