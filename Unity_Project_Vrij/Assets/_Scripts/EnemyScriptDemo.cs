using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptDemo : MonoBehaviour
{
    public List<Transform> WalkPoints;

    public void NextPoint()
    {

    }

    private void FixedUpdate()
    {
        transform.Translate(1f * Time.deltaTime,0,0);
    }
}
