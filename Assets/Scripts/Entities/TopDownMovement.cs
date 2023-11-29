using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    public Animator _animator;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovment(_movementDirection);
        _animator.SetFloat("Horizontal", _movementDirection.x);
        _animator.SetFloat("Vertical", _movementDirection.y);
        _animator.SetFloat("Speed", _movementDirection.sqrMagnitude);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovment(Vector2 direction)
    {
        direction = direction * speed;

        _rigidbody.velocity = direction;
    }
}