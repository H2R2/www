using UnityEngine;
using System.Collections;

public class hello : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        for (int i = 1; i < 31; i++)
        {


            int k;
            k = i;
            if (k % 5 == 0 && k % 3 == 0)
            {
                Debug.Log("fizeBize");
            }
            else if (k % 3 == 0)
            {

                Debug.Log("fizz");
            }
            else if (k % 5 == 0)
            {
                Debug.Log("Buzz");
            }

            else {
                Debug.Log(i);
            }
        }
        //Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
