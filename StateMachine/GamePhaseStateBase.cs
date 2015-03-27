using UnityEngine;
using System.Collections;
using System.Linq; // for Concat()

public class GamePhaseStateBase : uStateGeneric<GamePhaseStateMachine>
{
	// add custom members

	protected override void Reset ()
	{
		base.Reset();

		// initialize base members
		stateName = "";
		exitByTime = new ExitByTime(0.0f, "");
		transitions = (new Transition[] {
			//new Transition("IsCommited", "NextStateName")
		}).Concat(transitions).ToArray();

		// initialize custom members
	}

	public override void OnStateUpdate ()
	{
		// someting to do before decision of doing transition or not

		base.OnStateUpdate();
	}

	public override void OnStateEnter ()
	{
		base.OnStateEnter();
		
		// something to do at entering this state
//		Debug.Log("GamePhase : " + stateName, this);
	}

	public override void OnStateExit ()
	{
		// something to do at exiting this state
		stateMachine.ClearCommitFlags();

		base.OnStateExit();
	}

	public override void OnStateStay ()
	{
		base.OnStateStay();
		
		// something to do while each Update()
	}

	public virtual bool IsCommited ()
	{
		// true for transition and false for not
		return stateMachine.IsCommitedAll();
	}

	public virtual bool IsCommitedWithFinished ()
	{
		// true for transition and false for not
		return stateMachine.IsCommitedAll() && GameManager.instance.finished;
	}
}
