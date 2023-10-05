using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public List<GameObject> playerColor;
    public GameObject player;
    public int playerColorCount = 0;
    public Transform target;

    
    public bool PlayerDetected;
    public Transform detectorOrigin;
    public Color gizmoIdleColor = Color.green;
    public Color gizmoDetectedColor = Color.red;
    public bool showGizmos = true;
    

    void Awake()
    {
        player = playerColor[playerColorCount++];
    }

    private void Start()
    {
       
    }

    void Update()
    {
        float dist = Vector3.Distance(target.position, transform.position);
        print("Distance to other: " + dist);
        if (Input.GetButtonDown("Fire1"))
        {
            ChangePlayerColor();
        }
        if (dist <= 25 ) {
            Vector3 relativePos = target.position - transform.position;

            Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            transform.rotation = rotation;
            PlayerDetected = true;
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

    private void OnDrawGizmos()
    {
        if (showGizmos && detectorOrigin != null)
        {
            Gizmos.color = gizmoIdleColor;
            if (PlayerDetected)
                Gizmos.color = gizmoDetectedColor;
            Gizmos.DrawSphere((Vector3)detectorOrigin.position, 25);

        }
    }

}
