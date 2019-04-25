using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Towers
{
    public class Tower : TowerBase
    {
        private int attackPower;
        private int attackRange;
        private int costAmount;
        private int coolDown;
        private Transform targetEnemy;
        private float timeStamp = 0.0f;
        private GameObject towerPrefab;

        public GameObject TowerProjectile;

        private void Awake()
        {
            attackPower = AttackPower;
            attackRange = AttackRange;
            costAmount = CostAmount;
            towerPrefab = TowerPrefab;
            coolDown = CoolDown;
        }

        private void Start()
        {
            targetEnemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        }

        public void FireProjectile()
        {
            Instantiate(TowerProjectile, transform.forward, transform.rotation);
        }

        private void Update()
        {
            if (Time.time >= timeStamp && (targetEnemy.position - transform.position).magnitude < attackRange)
            {
                FireProjectile();
                timeStamp = Time.time + coolDown;
            }


        }
    }
}
