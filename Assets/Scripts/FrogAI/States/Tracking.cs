using UnityEngine;

public class Tracking : BaseState
{
    private FrogSM sm;

    public Tracking(FrogSM stateMachine) : base("Jumping", stateMachine)
    {
        sm = (FrogSM)this.stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
    }

}