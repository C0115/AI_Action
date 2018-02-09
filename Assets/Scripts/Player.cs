using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	//弾を撃ったか
	public bool IsBomb = false;
	public int BombCount = 0;
	//PlayerBombのプレハブ
	public GameObject bomb;

	//Startメソッドをコルーチンとして呼び出す
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(IsBomb){
			BombCount++;
			if(BombCount >= 50){
				IsBomb = false;
				BombCount = 0;
			}
		}else if (Input.GetKeyDown (KeyCode.Space)) {
			//爆弾をプレイヤーと同じ位置/角度で呼び出す
			Instantiate (bomb, transform.position, transform.rotation);
			//IsBombをtrueに
			IsBomb = true;
			//0.5秒待つ
			//yield return new WaitForSeconds (0.5f);
		}
	}
}
