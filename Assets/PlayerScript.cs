using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public List<GameObject> playerColor;
    public GameObject player;
    public int playerColorCount = 0;
    //public Transform target;
    public float range = 15;
    public string enemyTag = "Enemy";

    void Awake()
    {
        player = playerColor[playerColorCount++];
    }

    private void Start()
    {
       
    }

    void Update()
    {
        
        //print("Distance to other: " + dist);
        if (Input.GetButtonDown("Fire1"))
        {
            ChangePlayerColor();
        }

        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

    foreach (GameObject enemy in enemies)
    {
        // Calculate the distance between this object and the current enemy
        float dist = Vector3.Distance(transform.position, enemy.transform.position);

        if (dist <= range)
        {
            // Calculate the relative position of the enemy
            Vector3 relativePos = enemy.transform.position - transform.position;

            // Rotate towards the enemy
            Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            transform.rotation = rotation;
        }
    }
       
    }

    public void ChangePlayerColor()
    {
        player.SetActive(false);
        player = playerColor[playerColorCount++];
        if (playerColorCount == playerColor.Count)
        {
            playerColorCount = 0;
        }

        player.SetActive(true);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmos()
    {
        float radius = range;
        float angleStep = 360f / 360;
        Gizmos.color = Color.white;
        for (int i = 0; i < 360; i++){
            float angle = i * angleStep;
            Vector3 position = transform.position + radius * Vector3.right * Mathf.Cos(angle) + radius * Vector3.forward * Mathf.Sin(angle);

            Gizmos.DrawLine(position, position + Vector3.right * 0.1f);
        }
    }

}
