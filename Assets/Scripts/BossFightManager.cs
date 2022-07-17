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

    public bool playerBlocking;
    public bool enemyBlocking;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
