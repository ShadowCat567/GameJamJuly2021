using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BossFightManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject boss;

    public GameObject fightPanel;
    public GameObject BossHealth;

    public GameObject playerAction;
    public GameObject startAction;
    public GameObject bossAction;
    public GameObject victoryAction;

    public TMP_Text playerTxt;
    public TMP_Text startTxt;
    public TMP_Text bossTxt;
    public TMP_Text victoryTxt;

    public GameObject PAttackImg;
    public GameObject PBlockImg;

    //public GameObject BBlockImg;
    //public GameObject BAttackImg;

    public bool playerBlocking = false;
    public bool enemyBlocking = false;

    protected FightBaseState curState;
    public StartFightState fightStartState = new StartFightState();
    public PActionState playerActionState = new PActionState();
    public BActionState bossActionState = new BActionState();
    public EndFightState endState = new EndFightState();

    // Start is called before the first frame update
    void Start()
    {
        BossHealth.SetActive(false);
        ChangeState(fightStartState);
    }

    // Update is called once per frame
    void Update()
    {
        curState.UpdateState(boss.GetComponent<FinalBoss>(), player.GetComponent<Player>(), this);
    }

    public void ChangeState(FightBaseState newState)
    {
        if(curState != null)
        {
            curState.ExitState(boss.GetComponent<FinalBoss>(), player.GetComponent<Player>(), this);
        }

        curState = newState;

        if(curState != null)
        {
            curState.EnterState(boss.GetComponent<FinalBoss>(), player.GetComponent<Player>(), this);
        }
    }
}
