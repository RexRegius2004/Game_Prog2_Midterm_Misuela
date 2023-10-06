using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Red"))
        {
                Destroy(other.gameObject);
                Destroy(gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }


    }
}
