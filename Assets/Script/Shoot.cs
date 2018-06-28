using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class Shoot : MonoBehaviour, IInputClickHandler
{

    //Cube Prefab を扱う変数
    public GameObject shootingBall;
    public float BallPower;

    //AirTapされたときに呼び出される関数
    public void OnInputClicked(InputClickedEventData eventData)
    {
        //throw new NotImplementedException();
        Debug.Log("shoot!!");
        //Cube Prefab の情報を用いて実体化
        GameObject ball = GameObject.Instantiate(shootingBall);
        //自分からみて前方1.2mの位置を空間内の位置に変換
        ball.transform.position = Camera.main.transform.TransformPoint(0, 0, 1.2f);
        ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * BallPower);
        Destroy(ball, 5f);
    }

    // Start関数は初期化のために一度だけ実行される
    void Start()
    {
        //AirTap の通知が gameObject に渡るように設定
        InputManager.Instance.PushFallbackInputHandler(gameObject);
    }
    // Update は毎フレーム毎実行される
    void Update()
    {
    }
}
