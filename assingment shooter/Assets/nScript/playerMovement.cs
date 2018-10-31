using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public float speed=1.5f;
	public GameObject MISSILEs;
	
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			
			GameObject clone;
			clone =Instantiate(MISSILEs, transform.position, transform.rotation) as GameObject;
			 clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(-Vector3.forward * 1.1f);
			 Destroy(clone, 2f);
		}
		
			

	}

	void FixedUpdate()
	{
		float xm = Input.GetAxis("Vertical")*speed*Time.deltaTime;
		transform.Translate(-xm,0,0);
		transform.position= new Vector3(transform.position.x,Mathf.Clamp(transform.position.y,-0.4f,0.4f),transform.position.z);
	}

	public void OnTriggerEnter(Collider other)
     {       
		 
        if(other.tag == "enemy")
         {
             Destroy(other.gameObject);
             gameObject.SetActive(false);
			 Debug.Log("killed");
		 }   
             
             
             
         
		 
     }
	 
}
