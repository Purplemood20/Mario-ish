using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class Key : MonoBehaviour
{
    public UnityEvent whenPickUp;

    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            whenPickUp?.Invoke();  // faire les events avant le destroy 
            Destroy(gameObject);
        }
    }

    


}