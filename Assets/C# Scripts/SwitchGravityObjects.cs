using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGravityObjects : MonoBehaviour
{
    private Rigidbody2D rb;

    private bool top;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale *= -1;
            rotation();
        }
    }

    void rotation()
    {
        if (top == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 180f);
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
        }

        top = !top;
    }
}
