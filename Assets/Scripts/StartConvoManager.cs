using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartConvoManager : MonoBehaviour
{
    public GameObject player;
    public GameObject startPanel;

    public GameObject startConvo1;
    public GameObject startConvo2;
    public GameObject startConvo3;
    public GameObject startConvo4;

    public TMP_Text startCTxt1;
    public TMP_Text startCTxt2;
    public TMP_Text startCTxt3;
    public TMP_Text startCTxt4;

    protected StartConvoBaseState curState;
    public StartConvoState1 startC1 = new StartConvoState1();
    public StartConvoState2 startC2 = new StartConvoState2();
    public StartConvoState3 startC3 = new StartConvoState3();
    public StartconvoState4 startC4 = new StartconvoState4();

    // Start is called before the first frame update
    void Start()
    {
        ChangeState(startC1);
        player.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        curState.UpdateState(this);
    }

    public void ChangeState(StartConvoBaseState newState)
    {
        if(curState != null)
        {
            curState.ExitState(this);
        }

        curState = newState;

        if(curState != null)
        {
            curState.EnterState(this);
        }
    }
}
