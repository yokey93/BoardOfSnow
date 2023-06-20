using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yokey : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] float deathDelay = 3f;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            Debug.Log("PLAYER2 is now dead! ");
            crashEffect.Play();
            Destroy(gameObject, deathDelay);    
        }
    }
}
