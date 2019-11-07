using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpaceClicker : MonoBehaviour
{
    public Text SpaceText;
    int SpaceClickCounter;


    // Start is called before the first frame update
    void Start()
    {
        SpaceClickCounter = 0;


    }

    // Update is called once per frame
    void Update()
    {



        DisplayGreetMessage();

        CountSpacePressed();
    }

    private void CountSpacePressed()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpaceText.text = SpaceClickCounter.ToString();
            SpaceClickCounter += 1;
        }
    }

    private void DisplayGreetMessage()
    {
        if (SpaceClickCounter == 0)
        {
            SpaceText.text = "Press SPACE";
        }
    }
}
