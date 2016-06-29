using UnityEngine;
using System.Collections;

public class sikaku : MonoBehaviour {
  
        

    void Start() {
        //合計値を格納する変数
        int k = 0;
        //合計値を計算するループ分
        for (int i=1;i<11;i++) {
            k += i;
        }
        //合計値を出力
        Debug.Log(k);
        for (int j=1;j<5;j++) {
            string a = "";

            for (int i = 1; i <= 5; i++) {
                a += "□";

            }
            Debug.Log(a);
        }
    }
	
	void Update () {
	
	}
}
