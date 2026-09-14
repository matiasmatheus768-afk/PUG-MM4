using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidade = 5f;
    public float forcaPulo = 10f;

    private Rigidbody2D rb;

    private int pulos = 0;
    private int maxPulos = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimento
        float movimento = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(
            movimento * velocidade,
            rb.linearVelocity.y
        );

        // Pulo
        if (Input.GetKeyDown(KeyCode.Space) && pulos < maxPulos)
        {
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                forcaPulo
            );

            pulos++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            pulos = 0;
        }
    }
}