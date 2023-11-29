using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     private Rigidbody2D _rb;
    [SerializeField]private float _playerSpeed = 5; 
    [SerializeField]private float _jumpForce = 5;
    private float _playerInput;
    [SerializeField]private Animator _anim;


     void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponentInChildren<Animator>(); 
    }

    void Update()
    {
        /*if (Input.GetButtonDown("Jump") && GroundSensor._isGrounded) 
        {
            Jump();
        }
        _anim.SetBool("isJumping", !GroundSensor._isGrounded); */
    }

    private void FixedUpdate() 
    {
        MageMovement();
    }

    void MageMovement()
    {
        _playerInput = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2 (_playerInput*_playerSpeed, _rb.velocity.y);

          if(_playerInput > 0) 
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            _anim.SetBool("isRunning", true);
        }
        else if(_playerInput < 0) 
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            _anim.SetBool("isRunning", true);
        }
        else 
        {
            _anim.SetBool("isRunning", false);
        }
    }

    /*void Jump() 
    {
        _rb.AddForce(Vector2.up *_jumpForce, ForceMode2D.Impulse);
    }*/
}
