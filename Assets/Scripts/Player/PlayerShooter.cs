using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] GameObject arrowPrefab;
    [SerializeField] Transform firePoint;
    [SerializeField] float fireRate = 0.3f;

    SpriteRenderer spriteRenderer;
    float nextFireTime;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {

        // Determine direction based on which way the player is facing
        float direction = spriteRenderer.flipX ? -1f : 1f;

        GameObject arrow = Instantiate(arrowPrefab, firePoint.position, Quaternion.identity);
        arrow.GetComponent<Arrow>().SetDirection(direction);

        // Optional: play shoot animation
        GetComponent<Animator>()?.SetTrigger("shoot");

        AudioManager.Instance?.PlayShoot();
    }
}