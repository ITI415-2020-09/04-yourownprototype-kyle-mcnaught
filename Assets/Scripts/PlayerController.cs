using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{

	public float speed = 0;
	
	private Rigidbody rb;
	private int count;
	private float movementX;
	private float movementY;
	
	 public static float     bottomY = -9.5f;
	
    
    void Start()
    {
       rb = GetComponent<Rigidbody>();    
        count = 0;
    }


	void OnMove(InputValue movementValue)
   {
   	Vector2 movementVector = movementValue.Get<Vector2>();
   
   	movementX = movementVector.x;
   	movementY = movementVector.y;
   }
   
   
    void Update()
    {
        if (transform.position.y < bottomY) {
            SceneManager.LoadScene( "Scene_0" );                                   
            
        }
        
        
    }
   
   
   
      void FixedUpdate()
   {
   	Vector3 movement = new Vector3 (movementX, 0.0f, movementY);
   
   	rb.AddForce(movement * speed);
   }
   
    private void OnTriggerEnter(Collider other)
   {
   if(other.gameObject.CompareTag("Coin"))
   {
      	other.gameObject.SetActive(false);
      	
      	
      
   }
   }
}
