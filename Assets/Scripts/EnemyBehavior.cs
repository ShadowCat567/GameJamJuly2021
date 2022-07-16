using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] GameObject CombatManage;
    [SerializeField] GameObject Enemy;
    [SerializeField] Slider HealthBar;

    public int enemyDamageMod;

    int maxEnemyHealth = 20;
    public int curEnemyHealth;

    public bool dmgTaken = false;
    public bool genAttkVal = false;
    bool listRefilled = false;

    List<int> attkValLst = new List<int>();
    int[] attkValArray = { 1, 2, 3, 4 };

    System.Random rand = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        curEnemyHealth = maxEnemyHealth;
        enemyDamageMod = rand.Next(1, 3);
        listRefilled = true;
        RefillLst();
        HealthBar.maxValue = maxEnemyHealth;
        HealthBar.value = curEnemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.value = curEnemyHealth;

        if(curEnemyHealth <= 0)
        {
            Enemy.SetActive(false);
        }
    }

    public void TakeDamage(int damageTaken)
    {
        if (dmgTaken)
        {
            curEnemyHealth -= damageTaken;
            dmgTaken = false;
        }
    }

    public int GenerateAttackValue()
    {
        if (genAttkVal)
        {
            int attkValPos = rand.Next(0, attkValLst.Count);
            int attkVal = attkValLst[attkValPos];
            Debug.Log(attkVal);
            attkValLst.Remove(attkVal);
            genAttkVal = false;

            if(attkValLst.Count == 0)
            {
                listRefilled = true;
                RefillLst();
            }

            return attkVal;
        }

        else
        {
            return 2;
        }
    }

    void RefillLst()
    {
        if (listRefilled)
        {
            for (int i = 0; i < attkValArray.Length; i++)
            {
                attkValLst.Add(attkValArray[i]);
            }

            listRefilled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            CombatManage.GetComponent<CombatManager>().combatPanel.SetActive(true);
        }
    }
}
