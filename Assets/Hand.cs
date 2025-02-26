using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    Animator animator;
    public float speed;

    private float grip;
    private float gripcurrent;
    
    internal void SetGrip(float x)
    {
        grip = x;
    }

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (gripcurrent != grip)
        {
            gripcurrent = Mathf.MoveTowards(gripcurrent, grip, Time.deltaTime * speed);
            animator.SetFloat("Grip", gripcurrent);
        }
    }
}
