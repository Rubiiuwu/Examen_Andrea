using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    BoxCollider2D boxCollider;
    Animator anim;
    //public int value;

    void Start()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
       
    public void Destroy()
    {
        boxCollider.enabled = false;
        Destroy(this.gameObject);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
