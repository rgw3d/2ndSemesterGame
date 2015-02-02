using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	Vector3 gridSize = new Vector3(1,1,1);
	Vector3 movementDirection = new Vector3(0,0,1);
    


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPos = transform.position+movementDirection;
		newPos = new Vector3(Mathf.Round(newPos.x/gridSize.x)*gridSize.x,
		                 Mathf.Round(newPos.y/gridSize.y)*gridSize.y,
		                 Mathf.Round(newPos.z/gridSize.z)*gridSize.z);
		transform.TransformPoint (newPos);
	}
}