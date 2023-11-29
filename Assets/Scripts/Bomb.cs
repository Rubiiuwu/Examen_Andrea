using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    CircleCollider2D circleCollider;
    Animator _anim;

    void Start()
    {
        _anim = GetComponent<Animator>();
        circleCollider = GetComponent<CircleCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
       
    public void Destroy()
    {
        circleCollider.enabled = false;
        _anim.SetBool("Bomb", true);
    }

    void DestroyBomb()
    {
        Destroy(this.gameObject);
    }
}

