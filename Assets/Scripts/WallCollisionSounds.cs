using UnityEngine;

public class WallCollisionSounds : MonoBehaviour
{
    public AudioSource audioSource;       // drag the AudioSource here
    public float minImpactForce = 1f;    // only play if collision is strong enough

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check the collision impact
        if (collision.relativeVelocity.magnitude >= minImpactForce)
        {
            audioSource.Play(); // plays the assigned AudioClip on the AudioSource
        }
    }
}