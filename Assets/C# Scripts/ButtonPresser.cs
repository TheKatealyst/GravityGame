using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPresser : MonoBehaviour
{
    private Animator animator;
    public  GameObject Door;

    private void Awake()
    {
        
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("Pressed", true);
        Door.GetComponent<Door>().doorOpen();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("Pressed", false);
        Door.GetComponent<Door>().doorClosed();
    }
}

