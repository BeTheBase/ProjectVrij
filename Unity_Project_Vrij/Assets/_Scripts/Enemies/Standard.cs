using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Standard : MonoBehaviour
{
    public float Speed;

    public float MaxHealth;

    public float Health;

    public int GoldGiven;

    private EnemySpawner enemySpawner;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        enemySpawner = EnemySpawner.Instance;
        gameManager = GameManager.Instance;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Speed);
        if(transform.position.y <= -5)
        {
            enemySpawner.EnemiesAlive--;
            gameObject.SetActive(false);
        }
        if(Health <= 0)
        {
            enemySpawner.EnemiesAlive--;
            gameManager.Gold += GoldGiven;
            gameObject.SetActive(false);
        }
    }
}
