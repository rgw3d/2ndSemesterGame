using UnityEngine;
using System.Collections;

public class castleCRASH : MonoBehaviour {

    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;

    public float moveSpppped = 20f;

    public float maxY = 100;
    public float minY = -100;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(up)) {
            if(transform.position.y<maxY)
                transform.Translate(0, moveSpppped * Time.deltaTime, 0);
        }
        if (Input.GetKey(down)) {
            if (transform.position.y > minY)
            transform.Translate(0, -moveSpppped * Time.deltaTime, 0);
        }
        if (Input.GetKey(right)) {
            transform.Translate(moveSpppped * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(left)) {
            transform.Translate(-moveSpppped * Time.deltaTime, 0, 0);
            
        }

	
	}
}
