using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    float moveSpeed = 4.0f;
    float moveX;
    float moveY;

    Rigidbody2D rb;

    int maxHealth = 25;
    public int curHealth;
    public int attackStat;
    public int defenseStat;

    public bool generateAttackVal = false;
    public bool takenDamage = false;

    [SerializeField] GameObject pausePanel;

    System.Random rand = new System.Random();

    [SerializeField] Slider healthSlider;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        curHealth = maxHealth;
        attackStat = rand.Next(2, 5);
        defenseStat = rand.Next(3, 6);
        healthSlider.maxValue = maxHealth;
        healthSlider.value = curHealth;
    }

    // Start is called before the first frame update
    void Start()
    {
        
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
        if (generateAttackVal)
        {
            int attkVal = rand.Next(1, 7);
            generateAttackVal = false;
            return attkVal;
        }
        else
        {
            return 3;
        }
    }

    public void TakeDamage(int damageTaken)
    {
        if (takenDamage)
        {
            curHealth -= damageTaken;
            takenDamage = false;
        }
    }
}
