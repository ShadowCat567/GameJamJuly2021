using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartConvoState2 : StartConvoBaseState
{
    public override void EnterState(StartConvoManager scm)
    {
        scm.startConvo2.SetActive(true);
        scm.startCTxt2.text = "heh, heh, heh...Good luck finding your friend...we've taken them somewhere you won't find them. \n   [SPACE]";
    }

    public override void UpdateState(StartConvoManager scm)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            scm.ChangeState(scm.startC3);
        }
    }

    public override void ExitState(StartConvoManager scm)
    {
        scm.startConvo2.SetActive(false);
    }
}
