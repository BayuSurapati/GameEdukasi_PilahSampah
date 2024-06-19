using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TingkatLevel : MonoBehaviour
{
    public static TingkatLevel instance;
    public Text tingkatText;
    public int tingkatLvl;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KenaikanLevel()
    {
        if(DataScorer.score >= 100)
        {
            tingkatLvl = 1;
            GerakPindah.instance.speed += 1f * Time.deltaTime;
            tingkatText.text = "Tingkat Kecepatan: " + tingkatLvl.ToString();
        }
        if (DataScorer.score >= 200)
        {
            tingkatLvl = 2;
            GerakPindah.instance.speed += 2f * Time.deltaTime;
            tingkatText.text = "Tingkat Kecepatan: " + tingkatLvl.ToString();
        }if(DataScorer.score >= 300)
        {
            tingkatLvl = 3;
            GerakPindah.instance.speed += 3f * Time.deltaTime;
            tingkatText.text = "Tingkat Kecepatan: " + tingkatLvl.ToString();
        }if(DataScorer.score >= 400)
        {
            tingkatLvl = 4;
            GerakPindah.instance.speed += 4f * Time.deltaTime;
            tingkatText.text = "Tingkat Kecepetan: " + tingkatLvl.ToString();
        }
    }
}
