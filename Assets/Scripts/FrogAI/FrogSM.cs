using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogSM : StateMachine
{
    //The frogAI statemachine that will transition between the states of the frog

    public float speed = 4f;
    public float jumpForce = 14f;
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;

    [HideInInspector]
    public Idle idleState;
    [HideInInspector]
    public Tracking trackingState;
    [HideInInspector]
    public Jumping jumpingState;

    private void Awake()
    {
        idleState = new Idle(this);
        trackingState = new Tracking(this);
        jumpingState = new Jumping(this);
    }

    protected override BaseState GetInitialState()
    {
        return idleState;
    }

}