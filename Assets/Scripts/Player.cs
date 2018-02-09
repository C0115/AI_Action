using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	//PlayerBombのプレハブ
	public GameObject bomb;

	//Startメソッドをコルーチンとして呼び出す
	// Use this for initialization
	IEnumerator Start () {
		while(true){
			//if (Input.GetKey (KeyCode.Space)) {
				//爆弾をプレイヤーと同じ位置/角度で呼び出す
				Instantiate (bomb, transform.position, transform.rotation);
				//0.5秒待つ
				yield return new WaitForSeconds (0.5f);
			//}
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
