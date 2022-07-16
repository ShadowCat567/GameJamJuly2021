using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EndConvoBaseState
{
    public abstract void EnterState(EndConvoManager ecm);
    public abstract void UpdateState(EndConvoManager ecm);
    public abstract void ExitState(EndConvoManager ecm);
}
