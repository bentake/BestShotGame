using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BusShelterController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject player = GameObject.Find("Player");
        //Debug.Log("Player's distance to shelter is " + Vector3.Distance(transform.position, player.transform.position));
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered by: " + other.name);
 
    }
}
