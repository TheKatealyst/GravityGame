using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGravity : MonoBehaviour
{
    private PlayerController Player;
    private Rigidbody2D rb;

    public AudioSource GReversal;

    private bool grav = true;
    private bool top;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<PlayerController>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale *= -1;
            rotation();
            GReversal.Play();
        }

        if (grav == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Physics2D.gravity = new Vector2(0, 9.8f);
                rotation();
                GReversal.Play();
                grav = false;
            }
        }

        if (grav == false)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Physics2D.gravity = new Vector2(0, -9.8f);
                rotation();
                GReversal.Play();
                grav = true;
            }
        }
    }

    void rotation()
    {
        if(top == false)
        {
            transform.eulerAngles = new Vector3(0, 180, 180f);
        } else
        {
            transform.eulerAngles = Vector3.zero;
        }

        top = !top;
    }
}
