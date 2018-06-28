using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //衝突判定
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
