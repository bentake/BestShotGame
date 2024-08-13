using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spherecollision : MonoBehaviour
{
    public Text winText;
    public Text scoreText;
    private int score;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        SetscoreText();
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("nocollision"))
        {
            winText.text = "You Lose. Press R to restart.";

        }
        if (other.gameObject.CompareTag("disappear"))
        {
            //... then set the other object we just collided with to inactive.
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("goal"))
        {
            //... then set the other object we just collided with to inactive.
            score = score + 1;
            SetscoreText();

            other.enabled = false;

        }

        if (other.gameObject.CompareTag("border") && score == 5)
        {
            winText.text = "You Win. Press R to restart.";
        }

    }
    void SetscoreText()
    {
        //Set the text property of our our countText object to "Count: " followed by the number stored in our count variable.
        scoreText.text = "Score: " + score.ToString();
    }

}
