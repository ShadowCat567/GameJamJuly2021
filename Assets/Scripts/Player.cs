using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    float moveSpeed = 4.0f;
    float moveX;
    float moveY;

    Rigidbody2D rb;
    public BoxCollider2D bc;

    int maxHealth = 25;
    public int curHealth;
    public int attackStat;
    public int defenseStat;

    [SerializeField] GameObject pausePanel;
    [SerializeField] TMP_Text statText;

    System.Random rand = new System.Random();

    [SerializeField] Slider healthSlider;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
        curHealth = maxHealth;
        attackStat = rand.Next(2, 7);
        defenseStat = rand.Next(3, 7);
        healthSlider.maxValue = maxHealth;
        healthSlider.value = curHealth;
        statText.text = "Attack: " + attackStat + "\nDefense: " + defenseStat;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        healthSlider.value = curHealth;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }

        if(curHealth <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveX * moveSpeed, moveY * moveSpeed);
    }

    void PlayerMovement()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
    }

    public int GenerateAttackValue()
    {
        int attkVal = rand.Next(1, 7);
        return attkVal;
    }

    public void TakeDamage(int damageTaken)
    {
        curHealth -= damageTaken;
    }

    public void Heal(int healVal)
    {
        int newHealth = curHealth + healVal;
        if (newHealth < maxHealth)
        {
            curHealth += healVal;
        }

        else
        {
            int overHeal = newHealth - maxHealth;
            curHealth += (healVal - overHeal);
        }
    }
}
