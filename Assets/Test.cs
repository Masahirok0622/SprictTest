using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//コンソールにHello,Worldと表示
		Debug.Log ("Hello,Wourld");	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//変数の宣言
		int score;
		//変数の代入
		score = 150;
		//コンソールに変数の中身を表示
		Debug.Log(score);
	}

	// Update is called once per frame
	void Update () {

	}
}


using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 変数を初期化する
		int a = 3;
		int b = 4;
		// 変数aと変数bの合計値を変数cに代入する
		int c = a + b;
		// 変数cを表示する　
		Debug.Log (c);
	}

	// Update is called once per frame
	void Update () {

	}
}


using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// moneyを200で初期化する
		int money = 200;

		if (money >= 100) {
			//         moneyの値が100以上の場合、文字列を表示する
			Debug.Log ("ポーションを買う");
		}
	}

	// Update is called once per frame
	void Update () {

	}
}


using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// moneyを50で初期化する
		int money = 50;

		if (money >= 100) {
			// moneyが100以上だった場合
			Debug.Log ("ポーションを買う");
		} else {
			// moneyが100未満だった場合
			Debug.Log("武器を売る");
		}
	}

	// Update is called once per frame
	void Update () {

	}
}


using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// moneyを100で初期化する
		int money = 100;
		if (money <= 50) {
			// moneyが50以下だった場合の処理
			Debug.Log ("武器を売る");
		} else if( money >= 200) {
			// moneyが200以上だった場合の処理
			Debug.Log("武器を買う");
		} else {
			// それ以外の場合の処理
			Debug.Log("ポーションを買う");
		}
	}

	// Update is called once per frame
	void Update () {

	}
}


using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// numを1で初期化する
		int num = 1;
		// valに代入する値を条件によって変える(三項演算子)
		int val = (num == 1) ? -100 : 100;
		// valの値を表示する
		Debug.Log(val);
	}

	// Update is called once per frame
	void Update () {

	}
}


using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start(){
		// 変数aを3で初期化する
		int a = 3;
		if( a == 3 ){
			// 変数aが3の場合、変数bを5で初期化する
			int b = 5;
		}
		// 変数bの値を表示する
		Debug.Log( b );
	}

	// Update is called once per frame
	void Update () {

	}
}


using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 5回処理を繰り返す
		for (int i = 0; i < 5; i++) {
			Debug.Log (i);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}


using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// sumを0で初期化する
		int sum = 0;
		// 10回処理を繰り返す
		for (int i = 1; i <= 10; i++) {
			// iの値をsumに足す
			sum += i;
		}
		// sumの値を表示する
		Debug.Log (sum);
	}

	// Update is called once per frame
	void Update () {

	}
}


using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 要素数5の配列を初期化する
		int[] points = new int[5];

		// 配列の各要素に値を代入する
		points [0] = 30;
		points [1] = 20;
		points [2] = 50;
		points [3] = 10;
		points [4] = 80;

		// 配列の要素をすべて表示する
		for (int i = 0; i < 5; i++) {
			Debug.Log (points [i]);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}


using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 配列を初期化する
		int[] points = {30, 20, 50, 10, 80, 15, 60, 100};

		// 配列の要素数のぶんだけ処理を繰り返す
		for (int i = 0; i < points.Length; i++) {
			// 配列の要素が50以上の場合
			if( points[i] >= 50 ){
				// 配列の要素を表示する
				Debug.Log (points [i]);
			}
		}
	}

	// Update is called once per frame
	void Update () {

	}
}


using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	// 「Hello, UnityChan」と表示する関数
	void Hello(){
		Debug.Log ("Hello, UnityChan");
	}

	void Start () {
		// Hello関数を呼び出す
		Hello ();
	}

	// Update is called once per frame
	void Update () {

	}
}


using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	// 「Hello」に続けて引数の文字列を表示する関数
	void HelloName(string name){
		Debug.Log ("Hello, " + name);
	}

	void Start () {
		// HelloName関数に「Unity」という引数を渡す
		HelloName ("Unity");
	}

	// Update is called once per frame
	void Update () {

	}
}


using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// 第一引数と第二引数の値を足した値を返す関数
	int Add(int a, int b){
		// 第一引数と第二引数の値を足して、変数cに代入する
		int c = a + b;
		// 変数cを呼び出し元の関数に返す
		return c;
	}

	void Start () {
		// Add関数に「3」と「6」の引数を渡し、返り値をnum変数に代入する
		int num = Add (3, 6);
		// numを表示する
		Debug.Log (num);
	}

	// Update is called once per frame
	void Update () {

	}
}


public class Boss {        
	int hp;          // 体力
	int power; // 攻撃力

	public void Attack() { 
		// 攻撃用の関数
	}

	public  void Defence(int damage) { 
		// 防御用の関数
	}

}


using UnityEngine;
using System.Collections;

public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

}

public class Test : MonoBehaviour {

	void Start () {
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 攻撃用の関数を呼び出す
		lastboss.Attack();
		// 防御用の関数を呼び出す
		lastboss.Defence(3);
	}

	// Update is called once per frame
	void Update () {

	}
}