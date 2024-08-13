using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class instructioncontroller : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            // check if Esc key is pressed
            if (Input.GetKey(KeyCode.Escape))
            {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // stops game in Unity Editor
#else
                Application.Quit(); // stops game
#endif
            }// ends if Esc key is pressed

    }

    public void HandlebuttonPlayClicked()
    {
        Debug.Log("HandleButtonPlayClicked() started");

        SceneManager.LoadScene("Car");
    }
}
