using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCollider : MonoBehaviour
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
        if (other.CompareTag("Red") && CompareTag("Red") || other.CompareTag("Green") && CompareTag("Green") || other.CompareTag("Blue") && CompareTag("Blue")
)
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
