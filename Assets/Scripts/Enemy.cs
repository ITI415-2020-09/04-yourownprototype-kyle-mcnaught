﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
   public float speed = 0;

	public float upperLimit = 4.0f;
	public float lowerLimit = 1.0f;
	
	private int direction = 1;

    void Update()
    {
        if (transform.position.y > upperLimit) {
         direction = -1;
     }
     else if (transform.position.y < lowerLimit) {
         direction = 1;
     }
     Vector3 movement = Vector3.up * direction * speed * Time.deltaTime; 
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
