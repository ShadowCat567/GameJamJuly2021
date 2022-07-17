using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartConvoState3 : StartConvoBaseState
{
    public override void EnterState(StartConvoManager scm)
    {
        scm.startConvo3.SetActive(true);
        scm.startCTxt3.text = "[the Weevil disappears into the grass] \n \n   [SPACE]";
    }

    public override void UpdateState(StartConvoManager scm)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            scm.soundSource.Play();
            scm.ChangeState(scm.startC4);
        }
    }

    public override void ExitState(StartConvoManager scm)
    {
        scm.startConvo3.SetActive(false);
    }
}
