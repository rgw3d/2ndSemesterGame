using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public Sprite front;
    public Sprite back;
    public Sprite left;
    public Sprite right;
    private Sprite currentSprite;
	SpriteRenderer spriteRenderer;

	public float movementDistance = .05f;

	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = front;
        currentSprite = front;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
            rigidbody2D.AddForce(Vector2.up * movementDistance);
            if (currentSprite != back){
                spriteRenderer.sprite = back;
                currentSprite = back;
            }
		}
		if (Input.GetKey (KeyCode.S)) {
            rigidbody2D.AddForce(Vector2.up * -1 * movementDistance);
			//transform.Translate(0,-movementDistance,0);
            if (currentSprite != front){
                spriteRenderer.sprite = front;
                currentSprite = front;
            }
		}
		if (Input.GetKey (KeyCode.A)) {
            rigidbody2D.AddForce(Vector2.right * -1 * movementDistance);
			//transform.Translate(-movementDistance,0,0);
            if (currentSprite != left){
                spriteRenderer.sprite = left;
                currentSprite = left;
            }

		}
		if (Input.GetKey (KeyCode.D)) {
            rigidbody2D.AddForce(Vector2.right * movementDistance);
			//transform.Translate(movementDistance,0,0);
            if(currentSprite != right){
                spriteRenderer.sprite = right;
                currentSprite = right;
            }
		}
	}
}
