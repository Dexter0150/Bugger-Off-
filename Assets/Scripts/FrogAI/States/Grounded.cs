using UnityEngine;

public class Grounded : BaseState
{
    protected FrogSM sm;

    public Grounded(string name, FrogSM stateMachine) : base(name, stateMachine)
    {
        sm = (FrogSM)this.stateMachine;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        if (Input.GetKeyDown(KeyCode.Space))
            stateMachine.ChangeState(sm.jumpingState);
        if (Input.GetKeyDown(KeyCode.F))
            stateMachine.ChangeState(sm.trackingState);
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        
    }
}