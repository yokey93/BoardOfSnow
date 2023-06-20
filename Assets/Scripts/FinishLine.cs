using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // establish connection to our UI score

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;

    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("FINAL FINISH");
            // play animation particle effect
            // Restart the level 
            // Add Score to UI
            GetComponent<AudioSource>().Play();
            finishEffect.Play();

            logic.addScore();
        }
    }
}
