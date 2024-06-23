using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Animator anim;
    public float speed = 50.0f;
    private float move;
    private Rigidbody2D rb;
    public float jumpForce = 5.0f;
    private bool isGrounded;
    public GameObject StartPoint;
    public AppleCounter ac;
    public ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGrounded = false;
        ps.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.y < -7.0f)
        {
            transform.position = StartPoint.transform.position;
            ac.apples = 0;
        }
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        if (move !=0) anim.SetFloat("Speed", 1);
        else anim.SetFloat("Speed", 0);

        if (move > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (move < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            anim.SetBool("isJumping", false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            anim.SetBool("isJumping", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            ac.apples++;
            if (ac.apples == 7){
                ps.Play();
            }
            Destroy(other.gameObject);
        }
    }
}
