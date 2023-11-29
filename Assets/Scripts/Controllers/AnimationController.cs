using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    PlayerInputController controller;
    [SerializeField] Animator anim;

    private void Awake()
    {
        controller = GetComponent<PlayerInputController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += AnimState;
    }

    // Update is called once per frame
    void AnimState(Vector2 dir)
    {
        anim.SetBool("walk_front", dir.magnitude > 0);
        //anim.SetBool("walk_back")
    }
}
