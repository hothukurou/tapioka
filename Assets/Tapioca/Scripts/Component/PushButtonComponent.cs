﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushButtonComponent : MonoBehaviour
{

    public GameObject ball;
    private float pushPower = 400;  //ジャンプ力
    private float moveSpeed;        //移動速度
    private Rigidbody2D rbody;      //プレイヤー制御用Rigitbody2D

    public GameObject TextNokori;


    // Start is called before the first frame update
    void Start()
    {
        rbody = ball.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pushBall()
    {

        int tapioka_num = PlayerPrefs.GetInt("score", 0);

        if (tapioka_num >= 1)
        {
            tapioka_num--;
            PlayerPrefs.SetInt("score", tapioka_num);
            TextNokori.GetComponent<Text>().text = tapioka_num.ToString();
            GameObject obj = Instantiate(ball);
            //obj.transform.SetParent(canvasUI.transform, false);
            //obj.transform.SetSiblingIndex(0);
            //obj.GetComponent<TipsMessageComponent>().Message(message);
            //goJump = false;
            //obj.GetComponent<ballTapiocaComponent>().pushball();
        }
    }

}
