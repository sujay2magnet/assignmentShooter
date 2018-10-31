using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject enemy;
	public Vector3 spawnValue;
	 public float Timer = 2;
	 public int score;
	 

	 void Update()
	{
		SpawnWaves();
		
	}	
	
	
	void SpawnWaves()
	{
		 
		Timer -= 1 * Time.deltaTime;
         if (Timer <= 0f){
		GameObject clones;
		Vector3 spawnPosition = new Vector3(1.5f, Random.Range(-0.4f,0.4f), 0f);
		Quaternion spawnRotation=  Quaternion.Euler(0,90,90);
		clones =Instantiate( enemy,spawnPosition, spawnRotation);
		clones.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.left * 0.2f);
		 Timer = 2f;
		 }
		
	}

	 public void AddScore (int newScoreValue)
    {
        score =score+newScoreValue;
		Debug.Log(score);
        
    }

	void OnGUI()
	{
		GUI.Label(new Rect(0,0,100,50),"Score :"+score);
	}

	
}
