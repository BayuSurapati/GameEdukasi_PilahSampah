using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIOver : MonoBehaviour
{
    [SerializeField] string sceneRestart;
    [SerializeField] string sceneMain;

    public Text lastScoreText;

    public DataScorer score;
    // Start is called before the first frame update
    void Start()
    {
        ShowLastScore();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowLastScore()
    {
        lastScoreText.text = "Total Score: " + score + DeteksiSampah.instance.totalScore.ToString();
        Debug.Log(DeteksiSampah.instance.totalScore);
    }

    public void ButtonRestart()
    {
        SceneManager.LoadScene(sceneRestart);
    }

    public void ButtonQuit()
    {
        SceneManager.LoadScene(sceneMain);
    }
}
