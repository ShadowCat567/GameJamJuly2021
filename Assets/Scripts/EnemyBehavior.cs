using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyBehavior : MonoBehaviour
{
    public int enemyDamageMod;

    int maxEnemyHealth = 10;
    public int curEnemyHealth;

    public bool dmgTaken = false;
    public bool genAttkVal = false;

    System.Random rand = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        curEnemyHealth = maxEnemyHealth;
        enemyDamageMod = rand.Next(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
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
            int attkVal = rand.Next(1, 4);
            genAttkVal = false;
            return attkVal;
        }

        else
        {
            return 2;
        }
    }
}
