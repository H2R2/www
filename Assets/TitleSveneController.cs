using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class TitleSveneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) {

            SceneManager.LoadScene("lll");
        }
       

}
    public void ButtonPush()
    {
        SceneManager.LoadScene("lll");
    }
}
