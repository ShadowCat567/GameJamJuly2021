using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndConState2 : EndConvoBaseState
{
    public override void EnterState(EndConvoManager ecm)
    {

    }

    public override void UpdateState(EndConvoManager ecm)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ecm.ChangeState(ecm.endState3);
        }
    }

    public override void ExitState(EndConvoManager ecm)
    {

    }
}
