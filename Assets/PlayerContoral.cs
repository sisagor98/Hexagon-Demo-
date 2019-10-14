using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerContoral : MonoBehaviour
{
    public float playerSpeed= 600f;

    float movement =0f;
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");

    }


    private void FixedUpdate() {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement *  Time.fixedDeltaTime * -playerSpeed);

    }

    private void OnTriggerEnter2D(Collider2D other) {
       SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
    }

}
