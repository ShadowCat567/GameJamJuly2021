using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject player;

    public GameObject playerTurn;
    public GameObject enemyTurn;
    public GameObject startingTurn;
    public GameObject victoryTurn;

    protected CombatBaseState curState;
    public CombatEnemyState enemyAttack = new CombatEnemyState();
    public CombatPlayerState playerAttack = new CombatPlayerState();
    public CombatStartState startingState = new CombatStartState();
    public CombatVictoryState victoryState = new CombatVictoryState();

    // Start is called before the first frame update
    void Start()
    {
        ChangeState(startingState);
    }

    // Update is called once per frame
    void Update()
    {
        curState.UpdateState(enemy, player.GetComponent<Player>(), this);
    }

    public void ChangeState(CombatBaseState newState)
    {
        if(curState != null)
        {
            curState.ExitState(enemy, player.GetComponent<Player>(), this);
        }

        curState = newState;

        if(curState != null)
        {
            curState.EnterState(enemy, player.GetComponent<Player>(), this);
        }
    }
}
