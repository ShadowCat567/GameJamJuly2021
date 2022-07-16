using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartconvoState4 : StartConvoBaseState
{
    public override void EnterState(StartConvoManager scm)
    {
        scm.startConvo4.SetActive(true);
        scm.startCTxt4.text = "Oh no! I have to get them back! \nPress SPACE to continue";
    }

    public override void UpdateState(StartConvoManager scm)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            scm.startPanel.SetActive(false);
            scm.player.SetActive(true);
        }
    }

    public override void ExitState(StartConvoManager scm)
    {
        scm.startConvo4.SetActive(false);
    }
}
