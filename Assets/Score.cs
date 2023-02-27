using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public int highscore;

    public Text scoretext;
    public Text highscoretext;


    // Start is called before the first frame update
    void Start()
    {
        highscore= PlayerPrefs.GetInt("Highscore");
        StartCoroutine(Scor());
        
    }
    IEnumerator Scor()
    {     
        while (true)
        {
            score++;
            yield return new WaitForSeconds(0.05F);
        }

    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.ToString();
        highscoretext.text=highscore.ToString();

        if (score>highscore)
        {
            PlayerPrefs.SetInt("Highscore",score);
        }

    }
}
 