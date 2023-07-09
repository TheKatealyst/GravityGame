using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator animator;

    public AudioSource closed;
    public AudioSource open;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void doorOpen()
    {
        animator.SetBool("ButtonPressed", true);
        open.Play();
    }

    public void doorClosed()
    {
        animator.SetBool("ButtonPressed", false);
        closed.Play();
    }

}
