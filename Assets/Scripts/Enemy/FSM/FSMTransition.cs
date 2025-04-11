using System;

[Serializable]
public class FSMTransition
{
    public FSMDecision Decision; //playerinrangeof -> T or F
    public String TrueState;
    public string FalseState;
}
