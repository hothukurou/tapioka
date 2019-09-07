using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballTapiocaComponent : MonoBehaviour
{
    private float pushPower = 10000;  //ジャンプ力
    private float moveSpeed;        //移動速度
    private Rigidbody2D rbody;      //プレイヤー制御用Rigitbody2D
    public GameObject GameManager;

    // Start is called before the first frame update
    void Start()
    {
        GameManager= GameObject.Find("GameManager");

        rbody = this.GetComponent<Rigidbody2D>();
        float pushPower2 = pushPower * Random.Range(0.8f, 1.2f);
        float pushPower3 = pushPower * Random.Range(-0.2f, 0.2f);
        rbody.AddForce(Vector2.up * pushPower2);
        rbody.AddForce(Vector2.left * pushPower3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pushball() {

        //float pushPower2 = pushPower * Random.Range(0.8f, 1.2f);
        //float pushPower3 = pushPower * Random.Range(0.1f, 0.2f);
        //rbody.AddForce(Vector2.up * pushPower);
        //rbody.AddForce(Vector2.left * pushPower3);
    }

    // 衝突判定
    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("iiiiiii");
        //Debug.Log(col.gameObject.tag);

        if (col.gameObject.tag == "Shooter")
        {
            Destroy(this.gameObject);
        }else if (col.gameObject.tag == "Goal")
        {
            GameManager.GetComponent<GameCrManager>().addScore();
            Destroy(this.gameObject);
        }

    }


}
