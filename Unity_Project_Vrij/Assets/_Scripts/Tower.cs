using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Towers
{
    public class Tower : TowerBase
    {
        private float attackPower;
        private float attackRange;
        private float costAmount;
        private GameObject towerPrefab;

        public GameObject TowerProjectile;

        private void Awake()
        {
            attackPower = AttackPower;
            attackRange = AttackRange;
            costAmount = CostAmount;
            towerPrefab = TowerPrefab;
        }

        public void FireProjectile()
        {
            Instantiate(TowerProjectile, Vector3.forward, Quaternion.identity);

        }


    }
}
