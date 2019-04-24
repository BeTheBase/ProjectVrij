using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Towers
{
    public abstract class TowerBase : MonoBehaviour
    {
        public int AttackPower { get; set; }
        public int AttackRange { get; set; }
        public int CostAmount { get; set; }
        public GameObject TowerPrefab { get; set; }

        public void Init()
        {

        }
    }
}
