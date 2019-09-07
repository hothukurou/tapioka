using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCrManager : MonoBehaviour
{
    public int score = 0;
    public int tapioka_num = 0;
    public GameObject NowScene;

    public GameObject TextScore;
    public GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        tapioka_num = PlayerPrefs.GetInt("score",0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickRankingButtonEvent()
    {
        // TODO: ここでscoreデータ送信を行う

    }

    public void ClickSearchNextBsuttonEvent()
    {

    }

    // パチンコを打ちに行くボタン
    public void ClickGoingToCRButtonEvent()
    {

    }

    // タピオカを探しに行くボタン
    public void ClickGoingToSearchTapiokaButtonEvent()
    {

    }

    public void ClickTapiokaCup()
    {

    }

    public void addScore()
    {
        score++;
        TextScore.GetComponent<Text>().text = score.ToString();
    }


}
