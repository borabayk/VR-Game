using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepScore : MonoBehaviour
{
    public int RedPlayerScore;
    public int BluePlayerScore;

    public Text RedPlayerScoreText;
    public Text BluePlayerScoreText;
    public Text GameState;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    	
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RedPointWin")
        {
            RedPlayerAddScore();

            //GameState.text = "Game Over!";
            //Time.timeScale = 0;
        }

        if (other.tag == "BluePointWin")
        {
            BluePlayerAddScore();
        }

    }

    

    void BluePlayerAddScore()
    {
        BluePlayerScore++;
        BluePlayerScoreText.text = BluePlayerScore.ToString();
    }


    void RedPlayerAddScore()
    {
        RedPlayerScore++;
        RedPlayerScoreText.text = RedPlayerScore.ToString();
    }


}
