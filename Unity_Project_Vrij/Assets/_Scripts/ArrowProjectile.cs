using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Projectiles
{
    public class ArrowProjectile : MonoBehaviour
    {
        public float ProjectileSpeed;

        private Transform targetEnemy;

        private void Start()
        {
            targetEnemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        }

        private void FixedUpdate()
        {
            transform.LookAt(targetEnemy);
            GetComponent<Rigidbody>().velocity = transform.forward * ProjectileSpeed;
        }

        private void OnCollisionEnter(Collision other)
        {
            if(other.gameObject.tag == "Enemy")
            {
                Destroy(gameObject);
            }
        }
    }
}
