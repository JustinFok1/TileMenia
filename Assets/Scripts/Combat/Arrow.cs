using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] float speed = 15f;
    [SerializeField] float maxLifetime = 3f;
    [SerializeField] int damage = 1;

    Rigidbody2D rb;
    float direction = 1f; // 1 = right, -1 = left

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb.linearVelocity = new Vector2(direction * speed, 0f);
        Destroy(gameObject, maxLifetime);
    }

    public void SetDirection(float dir)
    {
        direction = dir;
        // Flip sprite if going left
        if (dir < 0)
            GetComponent<SpriteRenderer>().flipX = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Hit enemy
        EnemyPatrol enemy = other.GetComponent<EnemyPatrol>();
        if (enemy != null)
        {
            enemy.Die();
            Destroy(gameObject);
            return;
        }

        // Hit ground/wall
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            Destroy(gameObject);
        }
    }
}