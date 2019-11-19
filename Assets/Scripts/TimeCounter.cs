using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public Text TimeText;
    [SerializeField] int minTimeRange;
    [SerializeField] int maxTimeRange;
    public int GameTime;



    // Start is called before the first frame update
    void Start()
    {
        int Score = gameObject.GetComponent<SpaceClicker>().SpaceClickCounter;
        // generates random game time to play
        GameTime = Random.Range(minTimeRange, maxTimeRange);
        InvokeRepeating("TimeUpdate", 0, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void TimeUpdate()
    {
        if (GameTime >= 0)
        {
            TimeText.text = GameTime.ToString();
            Invoke("RemoveOneFromGameTime", 1);
            GameTime = GameTime - 1;
        }
        else
        {
            TimeText.text = "TIME OUT";
        }
    }
}
