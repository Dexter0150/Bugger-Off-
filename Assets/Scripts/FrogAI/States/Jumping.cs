using UnityEngine;

public class Jumping : BaseState
{
    private FrogSM sm;

    private bool grounded;
    private int groundedLayer = 1 << 6;

    public Jumping(FrogSM stateMachine) : base("Jumping", stateMachine)
    {
        sm = (FrogSM)this.stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        sm.spriteRenderer.color = Color.green;

        Vector2 vel = sm.rb.velocity;
        vel.y += sm.jumpForce;
        sm.rb.velocity = vel;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        if (grounded)
            stateMachine.ChangeState(sm.idleState);
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        grounded = sm.rb.velocity.y < Mathf.Epsilon && sm.rb.IsTouchingLayers(groundedLayer);
    }

}