using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartConvoState1 : StartConvoBaseState
{
    public override void EnterState(StartConvoManager scm)
    {
        scm.startPanel.SetActive(true);
        scm.startConvo1.SetActive(true);

        scm.startCTxt1.text = "Where's Azalea! \nI could have sworn they were right here a minute ago! \nPress SPACE to continue";
    }

    public override void UpdateState(StartConvoManager scm)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            scm.ChangeState(scm.startC2);
        }
    }

    public override void ExitState(StartConvoManager scm)
    {
        scm.startConvo1.SetActive(false);
    }
}
