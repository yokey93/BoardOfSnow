using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // to access Text in UI

public class LogicScript : MonoBehaviour
{
    // variables for adding score to UI
    public int newplayerScore;
    public Text newscoreText;

    // run and test the function from unity itself
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        newplayerScore = newplayerScore + 1;
        newscoreText.text = newplayerScore.ToString();
    }

}
