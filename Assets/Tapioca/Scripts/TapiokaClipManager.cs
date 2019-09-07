using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapiokaClipManager : MonoBehaviour
{
    public Text ScoreLabel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        Debug.Log("click!");
        int score=PlayerPrefs.GetInt("score",0);
        score += (int)(Random.value*20);
        ScoreLabel.text = "入手したタピオカ:"+ score;
        PlayerPrefs.SetInt("score",score);
        Transform myTransform = this.transform;
        // 座標を取得
        Vector2 pos = myTransform.position;
        pos.x = 900;    // x座標へ0.01加算

        myTransform.position = pos;
    }
}
