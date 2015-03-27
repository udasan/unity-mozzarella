# unity-mozzarella-states

This is sample of a uState for Unity (http://udasankoubou.blogspot.jp/2014/05/unityustate.html).

This is NOT complete project.
This was a part of a project of Oculus Game Jam in Japan 2014.

GamePhaseStateMachine : a state machine
GamePhaseStateBase : a base state to inherit
States/* : states

The flow of states are :
Prologue -> (Start -> Action -> Reaction -> End (-> Start -> ...)) -> Epilogue
