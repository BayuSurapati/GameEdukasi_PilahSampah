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
        lastScoreText.text = "Total Score: " + DeteksiSampah.instance.totalScore.ToString();
    }
}
