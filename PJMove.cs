using UnityEngine;

public class PJMove : MonoBehaviour
{

    private float velocidade = 5.0f;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxis("Horizontal");
        rb.linearVelocityX=mx * velocidade;
    }
}
