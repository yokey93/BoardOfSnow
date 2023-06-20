using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDectector : MonoBehaviour
{
    [SerializeField] float loadDelay = 2f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    //bool hasCrashed = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        // if (other.tag == "Ground" && !hasCrashed)
        if (other.tag == "Ground")
        {
            // hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();

            Debug.Log("HEAD hit the GROUND... bitch! :) ");
            crashEffect.Play();

            // GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);

            Invoke("ReloadScene", loadDelay); 
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
