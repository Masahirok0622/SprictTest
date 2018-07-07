using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 課題提出 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//5の配列を初期化する
		int[] array = new int[5];
	
		//配列の要素に値を代入
		array [0] = 10;
		array [1] = 20;
		array [2] = 30;
		array [3] = 40;
		array [4] = 50;

		//配列の要素すべてを表示する
		for (int i = 0; i < 5; i++) {
			Debug.Log (array [i]);
		}
		//配列の要素を逆順表示
		for (int j = 0; j > 5; j++) {
			Debug.Log (array [j]);
		}
	
	}

	// Update is called once per frame
	void Update () {
		
	}
}
