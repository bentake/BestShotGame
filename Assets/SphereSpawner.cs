using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SphereSpawner : MonoBehaviour
{
    // global variables needed for timers - DO NOT MODIFY THESE DIRECTLY
    private float countdownTimerDelay; // stores the amount of time for the timer methods in seconds
    private float countdownTimerStartTime; // stores the start time for the timer methods
    public GameObject MySphere; // drag Prefab from Assets here
    public GameObject Player; // drag RigidBodyFPSController from Hierarchy here
    void Start()
    {
        CountdownTimerReset(1.0f); // sets a 1 second timer
                                   // note setting fixed height to y = 10 so sphere drops
        float XIncrement = Random.Range(-0.5f, 0.5f); // adding to x position so sphere's are not placed on top of player
        float ZIncrement = Random.Range(3f, 6f); // adding to z position
        Instantiate(MySphere, new Vector3(Player.transform.position.x + XIncrement, 10f, Player.transform.position.z + ZIncrement), Quaternion.identity);
        CountdownTimerReset(1f); // sets a 1 second timer
    }
    // Update is called once per frame
    void FixedUpdate()
    {

    }
    // method to reset the timer to the number of seconds specified in dealInSeconds
    private void CountdownTimerReset(float delayInSeconds)
    {
        countdownTimerDelay = delayInSeconds;
        countdownTimerStartTime = Time.time;
    }
    private float CountdownTimerSecondsRemaining()
    {
        float elapsedSeconds = Time.time - countdownTimerStartTime;
        float timeLeft = countdownTimerDelay - elapsedSeconds;
        return timeLeft;
    }
}