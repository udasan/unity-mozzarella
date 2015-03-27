using UnityEngine;
using System.Collections;
using System.Linq; // for Concat()

public class GamePhasePrologueState : GamePhaseStateBase
{
	// add custom members
	
	protected override void Reset ()
	{
		base.Reset();
		
		// initialize base members
		stateName = "GamePhasePrologueState";
		exitByTime = new ExitByTime(0.0f, "");
		transitions = (new Transition[] {
			new Transition("IsCommited", "GamePhaseStartState")
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
		
		AudioController.GetAudioController("BGM").Play("Yami");
	}
	
	public override void OnStateExit ()
	{
		// something to do at exiting this state
		
		base.OnStateExit();
	}
	
	public override void OnStateStay ()
	{
		base.OnStateStay();
		
		// something to do while each Update()
	}
}
