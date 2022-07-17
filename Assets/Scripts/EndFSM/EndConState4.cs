using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndConState4 : EndConvoBaseState
{
    public override void EnterState(EndConvoManager ecm)
    {
        ecm.endConvo4.SetActive(true);
        ecm.endTxt4.text = "I'm fine, let's go home \n   [SPACE]";
    }

    public override void UpdateState(EndConvoManager ecm)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ecm.soundSource.Play();
            SceneManager.LoadScene(2);
        }
    }

    public override void ExitState(EndConvoManager ecm)
    {
        ecm.endConvo4.SetActive(false);
    }
}
