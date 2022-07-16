using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndConvoManager : MonoBehaviour
{
    public GameObject player;
    public GameObject endPanel;

    public GameObject endConvo1;
    public GameObject endConvo2;
    public GameObject endConvo3;
    public GameObject endConvo4;

    public TMP_Text endTxt1;
    public TMP_Text endTxt2;
    public TMP_Text endTxt3;
    public TMP_Text endTxt4;

    protected EndConvoBaseState curState;
    public EndConState1 endState1 = new EndConState1();
    public EndConState2 endState2 = new EndConState2();
    public EndConState3 endState3 = new EndConState3();
    public EndConState4 endState4 = new EndConState4();

    // Start is called before the first frame update
    void Start()
    {
        ChangeState(endState1);
    }

    // Update is called once per frame
    void Update()
    {
        curState.UpdateState(this);   
    }

    public void ChangeState(EndConvoBaseState newState)
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
