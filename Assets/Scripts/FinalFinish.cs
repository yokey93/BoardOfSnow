using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalFinish : MonoBehaviour
{
    [SerializeField] float loadDelay = 2f;
    [SerializeField] ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishEffect.Play();
            Invoke("ReloadScene", loadDelay);
            GetComponent<AudioSource>().Play();
        }
    }

    // create a method to call for a first (0) scene-- Invoke()
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
