using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class FinalBoss : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject Boss;
    public GameObject friend;
    [SerializeField] Slider HealthBar;
    [SerializeField] GameObject BossManager;

    public int DmgMod;
    public int defenseStat;
    public string charName = "Boss";

    float distToPlayer = 15.0f;
    float velocity = 2.5f;

    public int curHealth;
    int maxHealth = 25;

    System.Random rand = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        friend.SetActive(false);
        curHealth = maxHealth;
        DmgMod = rand.Next(2, 5);
        defenseStat = rand.Next(3, 6);
        HealthBar.maxValue = maxHealth;
        HealthBar.value = curHealth;
        BossManager.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(curHealth <= 0)
        {
            friend.SetActive(true);
            Boss.SetActive(false);
        }

        if (Vector3.Distance(transform.position, player.transform.position) <= distToPlayer)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, velocity * Time.deltaTime);
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

    public int Blocking()
    {
        int blockingVal = rand.Next(0, 2);
        return blockingVal;
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
