using UnityEngine;

public class WallCollisionSound : MonoBehaviour
{
    public AudioSource audioSource;
    public float minImpactForce = 1f;

    void OnCollisionEnter(Collision collision)
    {
        // Play sound only if impact is strong enough
        if (collision.relativeVelocity.magnitude >= minImpactForce)
        {
            audioSource.PlayOneShot(audioSource.clip);
        }
    }
}