using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFieldManager : MonoBehaviour
{
    public GameObject canvas;
    public GameObject tapioka;
    public Sprite[]  backSprite = new Sprite[3];
    public GameObject backImageObject;
    private SpriteRenderer backImageRenderer;
    private int backNum=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ClickSearchNextBsuttonEvent()
    {
        this.backNum++;
        if (this.backNum >= 3) this.backNum = 0;
        // 背景画像をランダムで変更する
        this.backImageRenderer = backImageObject.GetComponent<SpriteRenderer>();
        this.backImageRenderer.sprite = this.backSprite[this.backNum];


        //タピオカをセットする
        GameObject obj = Instantiate(tapioka, new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
        obj.transform.SetParent(canvas.transform, false);
        
        Transform myTransform = obj.transform;
        // 座標を取得
        Vector2 pos = myTransform.position;
        pos.x = Random.value*6-3;    // x座標へ0.01加算
        pos.y = Random.value*6-3;    // y座標へ0.01加算

        myTransform.position = pos;
  
        //obj.transform.SetSiblingIndex(0);
    }

    // パチンコを打ちに行くボタン
    public void ClickGoingToCRButtonEvent()
    {
        SceneManager.LoadScene("GameCrScene");

    }


}
