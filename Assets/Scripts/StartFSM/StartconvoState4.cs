using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartconvoState4 : StartConvoBaseState
{
    public override void EnterState(StartConvoManager scm)
    {
        scm.startConvo4.SetActive(true);
        scm.startCTxt4.text = "Oh no! I have to get them back! \n   [SPACE]";
    }

    public override void UpdateState(StartConvoManager scm)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            scm.soundSource.Play();
            scm.startPanel.SetActive(false);
            scm.player.SetActive(true);
        }
    }

    public override void ExitState(StartConvoManager scm)
    {
        scm.startConvo4.SetActive(false);
    }
}
