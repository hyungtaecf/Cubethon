using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public AudioSource _as;
    public float pitchDecreasingLevel = 0.5f;

    private bool collided;


    void Start()
    {
        _as = GetComponent<AudioSource>();
        collided = false;
    }

    void Update()
    {
        if (collided)
        {
            _as.pitch -= pitchDecreasingLevel*Time.deltaTime;
            Debug.Log(_as.pitch.ToString());
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag.ToString() == "Player")
        {
            Debug.Log("player collided with one object");
            collided = true;
        }
    }
}
