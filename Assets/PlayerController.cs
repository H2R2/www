using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Rigidbody rigid;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(
            moveHorizontal, 0.0f, moveVertical);

        rigid.AddForce(movement*10);

    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        rigid.AddForce(new Vector3(0f, 500f, 500f));
    //    }
    //    if (Input.GetKeyDown(KeyCode.LeftArrow))
    //    {
    //        rigid.AddForce(new Vector3(-500f, 0f, 1f));
    //    }

    }
}
