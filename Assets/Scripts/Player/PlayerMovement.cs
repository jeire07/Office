using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator anim;

    private CharacterControl _control;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _control = GetComponent<CharacterControl>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        _control.OnMoveEvent += Move;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
        bool isMoving = (_rigidbody.velocityX != 0) || (_rigidbody.velocityY != 0);
        bool state = (isMoving) ? true : false;
        anim.SetBool("IsWalking", state);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        _rigidbody.velocity = direction * 5;
    }
}
