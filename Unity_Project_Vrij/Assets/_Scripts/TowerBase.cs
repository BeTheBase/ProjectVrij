using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Towers
{
    public abstract class TowerBase : MonoBehaviour
    {
        public int AttackPower;
        public int AttackRange;
        public int CostAmount;
        public int CoolDown;
        public GameObject TowerPrefab { get; set; }

        public void Init()
        {

        }
    }
}
