using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StartConvoBaseState
{
    public abstract void EnterState(StartConvoManager scm);
    public abstract void UpdateState(StartConvoManager scm);
    public abstract void ExitState(StartConvoManager scm);
}
