using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D _rb;
    [SerializeField]private float _playerSpeed = 5.5f;
    [SerializeField]private float _jumpForce = 5.5f;
    private float _playerInput;
    [SerializeField]private Animator _anim;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponentInChildren<Animator>();
        //Jump();
    }
    void Update()
    {
        _playerInput = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2 (_playerInput*_playerSpeed, _rb.velocity.y);
    }

    void FixedUpdate()
    {

    }


    //transform.rotation = Quaternion.Euler(0, 0, 0);
    //_anim.SetBool("isRunning", true);
    



}
