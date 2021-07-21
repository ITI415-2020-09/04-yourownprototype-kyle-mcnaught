using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy2 : MonoBehaviour
{
   public float speed = 0;

	public float leftLimit = 4.0f;
	public float rightLimit = 1.0f;
	
	private int direction = 1;

    void Update()
    {
        if (transform.position.x > rightLimit) {
         direction = -1;
     }
     else if (transform.position.x < leftLimit) {
         direction = 1;
     }
     Vector3 movement = Vector3.right * direction * speed * Time.deltaTime; 
     transform.Translate(movement); 
    }
    
     private void OnTriggerEnter(Collider other)
   {
   if(other.gameObject.CompareTag("Player"))
   {
      	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    
   }
   }
    
}
