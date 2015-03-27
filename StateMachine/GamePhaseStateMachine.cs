using UnityEngine;
using System.Collections;

public class GamePhaseStateMachine : uStateMachine
{
	// add custom members
	bool[] commitFlags_;

	protected override void Reset ()
	{
		base.Reset();

		// initialize base memebrs
		defaultStateName = "GamePhasePrologueState";

		// initialize custom members

		// initialize states
		//DestroyAllStates();
		//CreateStates(new System.Type[] { typeof(State1), typeof(State2) });
	}

	protected override void Start ()
	{
		base.Start();

		commitFlags_ = new bool[GameManager.instance.numberOfMozzarellars];
	}

	public bool IsCommitedAll ()
	{
		foreach (bool b in commitFlags_) {
			if (!b) { return false; }
		}
		return true;
	}

	public void ClearCommitFlags ()
	{
		for (int i = 0; i < GameManager.instance.numberOfMozzarellars; i++) {
			commitFlags_[i] = false;
		}
	}

	public void CommitFlag (int mozzarellarId)
	{
		if (mozzarellarId < 0 || mozzarellarId >= GameManager.instance.numberOfMozzarellars) { return; }

		commitFlags_[mozzarellarId] = true;
	}
}
