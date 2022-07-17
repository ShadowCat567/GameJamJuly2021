using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndConState2 : EndConvoBaseState
{
    public override void EnterState(EndConvoManager ecm)
    {
        ecm.endConvo2.SetActive(true);
        ecm.endTxt2.text = "Ladybug! You made it! \n   [SPACE]";
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
        ecm.endConvo2.SetActive(false);
    }
}
