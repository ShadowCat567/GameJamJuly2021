using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndConState4 : EndConvoBaseState
{
    public override void EnterState(EndConvoManager ecm)
    {

    }

    public override void UpdateState(EndConvoManager ecm)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(2);
        }
    }

    public override void ExitState(EndConvoManager ecm)
    {

    }
}
