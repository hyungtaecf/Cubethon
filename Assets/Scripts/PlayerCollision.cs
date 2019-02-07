using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public Score score;
    public AudioClip collisionSound;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<AudioSource>().PlayOneShot(collisionSound);
            movement.enabled = false;
            score.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
            
    }

}
