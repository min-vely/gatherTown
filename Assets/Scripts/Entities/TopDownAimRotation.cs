using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private Transform characterPivot;
    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownCharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }

    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
        //characterRenderer.flipX = characterRenderer.flipY;
    }
}