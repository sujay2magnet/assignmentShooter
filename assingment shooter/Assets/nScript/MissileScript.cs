using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MissileScript : MonoBehaviour {

	
    public int scoreValue;
     private GameController gameController;

     void Start ()
    {
        scoreValue=1;
        GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent <GameController>();
        }
        if (gameController == null)
        {
            Debug.Log ("Cannot find 'GameController' script");
        }
    }
	
	
	
	

	public void OnTriggerEnter(Collider other)
     {       
		 
            
 
         if(other.tag == "enemy")
         {
              gameController.AddScore (scoreValue);
             Destroy(other.gameObject);
             Destroy(gameObject);
			 
			 
			 
			 
			 
         }
	 }

	 

}
