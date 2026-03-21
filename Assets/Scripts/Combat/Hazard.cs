using UnityEngine;

public class Hazard : MonoBehaviour
{
    [SerializeField] int damage = 999; // Instant kill by default

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>()?.TakeDamage(damage);
        }
    }
}