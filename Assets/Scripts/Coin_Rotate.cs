using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Rotate : MonoBehaviour
{
    
    void Update()
    {
        transform.Rotate(new Vector3(60, 0, 0) * Time.deltaTime);
    }
}
