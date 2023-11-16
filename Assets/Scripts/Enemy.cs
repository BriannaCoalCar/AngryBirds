using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public AudioSource audio;
    [SerializeField] float destroyImpactMagnitude = 5;
    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.GetComponent<Bird>()) {
            audio.Play();
            Invoke(nameof(DestroySprite), 0.3f);
            
        }

        if(collision.relativeVelocity.magnitude > destroyImpactMagnitude) {
            audio.Play();
            Invoke(nameof(DestroySprite), 0.3f);
        }
    }

    void DestroySprite()
    {
        Destroy(gameObject);
    }
}
