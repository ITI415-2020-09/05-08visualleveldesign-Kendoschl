using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject Block1;
    public GameObject Block2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RedPickUp"))
        {
            other.gameObject.SetActive(false);
            Block1.SetActive(false);
        }
        else if (other.gameObject.CompareTag("BluePickUp"))
        {
            other.gameObject.SetActive(false);
            Block2.SetActive(false);
        }
    }

            // Start is called before the first frame update
            void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
