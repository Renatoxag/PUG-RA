using UnityEngine;

public class PjMove : MonoBehaviour
{
    private float velocidade = 5.0f;
    public Rigidbody2D rb;

    Vector2 forçaPulo;

    int pulos = 0;
    int maxPulos = 2;

    void Start()
    {
        forçaPulo = new Vector2(0.0f, 8.0f);
    }

    void Update()
    {
        float mX = Input.GetAxisRaw("Horizontal");
        rb.linearVelocityX = mX * velocidade;

        if (Input.GetKeyDown(KeyCode.Space) && pulos < maxPulos)
        {
            rb.linearVelocityY = 0;
            rb.AddForce(forçaPulo, ForceMode2D.Impulse);

            pulos++;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            pulos = 0;
        }
    }
}

