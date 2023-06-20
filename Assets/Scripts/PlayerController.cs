using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // 0.5 torque amount IN APP but 3 torque for BUILD download ? idk why bug maybe? **
    [SerializeField] float torqueAmount = 0.5f;
    [SerializeField] float boostSpeed = 20f;
    [SerializeField] float baseSpeed = 10f;
    SurfaceEffector2D[] effectors = new SurfaceEffector2D[1];

    Rigidbody2D rb2d;
    SurfaceEffector2D se2d;
    bool canMove = true;

    void Start()
    {
        // store the rigidbody component in a variable 
        rb2d = GetComponent<Rigidbody2D>();
        // se2d = FindObjectOfType<SurfaceEffector2D>();
        effectors = FindObjectsOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        CallMenu();

        if (canMove)
        {
            RotatePlayer();
            BoostPlayer();
        }

    }

    // disable player on crash
    public void DisableControls()
    {
        canMove = false;
    }

    // speed the player with UP arrow
    void BoostPlayer()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            foreach (SurfaceEffector2D effect in effectors)
            {
                Debug.Log("UP ARROW is hit!");
                effect.speed = boostSpeed;
            }
        }

        else
        {
            foreach (SurfaceEffector2D effect in effectors)
            {
                effect.speed = baseSpeed;
            }
        }
    }

    // spin the player with LEFT and RIGHT arrows
    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }

    void CallMenu()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
        }
    }
}