using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changescene : MonoBehaviour
{
    public void Level()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
