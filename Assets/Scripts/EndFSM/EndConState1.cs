using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndConState1 : EndConvoBaseState
{
    public override void EnterState(EndConvoManager ecm)
    {
        ecm.endConvo1.SetActive(true);
        ecm.endTxt1.text = "Azalea! \n   [SPACE]";
    }

    public override void UpdateState(EndConvoManager ecm)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ecm.soundSource.Play();
            ecm.ChangeState(ecm.endState2);
        }
    }

    public override void ExitState(EndConvoManager ecm)
    {
        ecm.endConvo1.SetActive(false);
    }
}
