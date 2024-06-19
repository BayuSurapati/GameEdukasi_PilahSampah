using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    [SerializeField] string lvl1, lvl2, lvl3, lvl4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level1()
    {
        SceneManager.LoadScene(lvl1);
    }
    public void Level2()
    {
        SceneManager.LoadScene(lvl2);
    }
    public void Level3()
    {
        SceneManager.LoadScene(lvl3);
    }
    public void Level4()
    {
        SceneManager.LoadScene(lvl4);
    }
}
