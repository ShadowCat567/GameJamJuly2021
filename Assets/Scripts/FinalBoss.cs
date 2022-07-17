using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class FinalBoss : MonoBehaviour
{
    [SerializeField] GameObject Boss;
    [SerializeField] Slider HealthBar;
    [SerializeField] GameObject BossManager;

    public int DmgMod;
    public int defenseStat;
    public string charName = "Boss";

    public int curHealth;
    int maxHealth = 40;

    System.Random rand = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
        DmgMod = rand.Next(2, 4);
        defenseStat = rand.Next(2, 5);
        HealthBar.maxValue = maxHealth;
        HealthBar.value = curHealth;
        BossManager.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(curHealth <= 0)
        {
            Boss.SetActive(false);
        }
    }

    public void TakeDamage(int damage)
    {
        curHealth -= damage;
    }

    public int GenerateAttackValue()
    {
        int attkVal = rand.Next(1, 7);
        return attkVal;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            BossManager.SetActive(true);
            BossManager.GetComponent<BossFightManager>().fightPanel.SetActive(true);
        }
    }
}
