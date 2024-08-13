using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelterDetector : MonoBehaviour
{

    float TotalTime;
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        TotalTime = 0.0f;
        Player = GameObject.Find("RigidBodyFPSController");
    }

    // Update is called once per frame
    void Update()
    {
        TotalTime += Time.deltaTime;
        if (TotalTime > 0.5f) // check every 1/2 second instead of every frame
        {
            TotalTime = 0.0f;
            float dist = Vector3.Distance(Player.transform.position, transform.position);

            Debug.Log("You are this close: " + dist);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Shelter entered");
    }
}
