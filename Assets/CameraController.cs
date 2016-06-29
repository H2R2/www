using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    [SerializeField]
    Transform charaTransform;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = charaTransform.position;
        Vector3 charpos = transform.position;
        pos.z = charaTransform.position.z - 5;
        charpos = pos;
        //charaTransform.position = pos;
        transform.position = charpos;

        // transform.position = charaTransform.position + new Vector3(0,1,3);

    }
}
