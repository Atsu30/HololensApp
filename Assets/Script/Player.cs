using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class Player : MonoBehaviour, IInputClickHandler
{

    //Cube Prefab を扱う変数
    public GameObject shootingBall;
    public float BallPower;

    //AirTapされたときに呼び出される関数
    public void OnInputClicked(InputClickedEventData eventData)
    {
        GameObject ball = GameObject.Instantiate(shootingBall);
        //ballを向いている方向に発射
        ball.transform.position = Camera.main.transform.TransformPoint(0, 0, 1.2f);
        ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * BallPower, ForceMode.Impulse);
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
