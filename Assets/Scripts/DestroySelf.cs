using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        
        if(other.gameObject.tag == "Platform") {
            Destroy (gameObject, 0.5f);
        }
    }
}
