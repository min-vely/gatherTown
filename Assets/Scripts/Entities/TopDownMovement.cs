using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    Animator _animator;
    string currentState;
    const string Idle = "Idle";
    const string Walk_Front = "Walk_Front";
    const string Walk_Back = "Walk_Back";
    const string Walk_Left = "Walk_Left";
    const string Walk_Right = "Walk_Right";

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = transform.Find("Character").GetComponent<Animator>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovment(_movementDirection);
        if (_rigidbody.velocity == new Vector2(0, 0))
        {
            ChangeAnimationState(Idle);
        }
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

    void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;
        _animator.Play(newState);
        currentState = newState;
    }
}