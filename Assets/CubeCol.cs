using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CubeCol : MonoBehaviour {


[SerializeField]//エディターからのみアクセス
    GameObject textogj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision other) {
        // Destroy(other.gameObject);
        textogj.SetActive(true);//活性化できる
    }
    void OnTriggerEnter(Collider other)
    {
        // Destroy(other.gameObject);
        textogj.SetActive(true);//活性化できる
        Text t = textogj.GetComponent<Text>();
        t.text = "きすすすすすｓ";
    }
}
