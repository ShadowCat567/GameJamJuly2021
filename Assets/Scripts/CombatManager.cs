using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CombatManager : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject player;

    public GameObject playerTurn;
    public GameObject enemyTurn;
    public GameObject startingTurn;
    public GameObject victoryTurn;

    public TMP_Text playerTurnTxt;
    public TMP_Text enemyTurnTxt;
    public TMP_Text victoryTxt;
    public TMP_Text startingTxt;

    public GameObject PAttkImg;
    public GameObject PBlockImg;

    public GameObject combatPanel;

    public GameObject EnemyHealth;

    public bool blocking;
    public int enemyDmgDealt;

    protected CombatBaseState curState;
    public CombatEnemyState enemyAttack = new CombatEnemyState();
    public CombatPlayerState playerAttack = new CombatPlayerState();
    public CombatStartState startingState = new CombatStartState();
    public CombatVictoryState victoryState = new CombatVictoryState();

    // Start is called before the first frame update
    void Start()
    {
        EnemyHealth.SetActive(false);
        ChangeState(startingState);
    }

    // Update is called once per frame
    void Update()
    {
        curState.UpdateState(enemy.GetComponent<EnemyBehavior>(), player.GetComponent<Player>(), this);
    }

    public void ChangeState(CombatBaseState newState)
    {
        if(curState != null)
        {
            curState.ExitState(enemy.GetComponent<EnemyBehavior>(), player.GetComponent<Player>(), this);
        }

        curState = newState;

        if(curState != null)
        {
            curState.EnterState(enemy.GetComponent<EnemyBehavior>(), player.GetComponent<Player>(), this);
        }
    }
}
