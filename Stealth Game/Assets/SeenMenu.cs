using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeenMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject menu; // Assign in inspector
   public GameObject WinMenu;
    public bool isShowing;
     public FindPlayer seen; 
     public FindPlayerVertical seenV; 
     public DoorState entered; 
     public bool gameEnded;


     void Start(){
         menu.SetActive(isShowing);
         gameEnded = false;
     }

     void Update(){
        if(gameEnded==false){
       if (seen.CanSeePlayer || seenV.CanSeePlayer) {
       
             isShowing = !isShowing;
             menu.SetActive(isShowing);
              gameEnded = true;
              pause();
         }
         else if(entered.entered){
            isShowing = !isShowing;
             WinMenu.SetActive(isShowing);
              gameEnded = true;   
              pause();     
         }
     }
          if(gameEnded==true &&Input.GetKey (KeyCode.R) ){
                    resume();
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } else if(gameEnded==true &&Input.GetKey (KeyCode.Q) ){
                    quit();
        }
     }

     void pause(){
             Time.timeScale = 0f;
     }
      void resume(){
            Time.timeScale = 1f; 
     }
     void quit(){
        Application.Quit();
     }
}
