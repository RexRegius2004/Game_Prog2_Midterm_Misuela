using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float enemySpeed;
    public Transform target;
   

    void Awake()
    {
        
    }

    void Update()
    {
        var step = enemySpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
        target.position *= -1.0f;
        }
    }


}
