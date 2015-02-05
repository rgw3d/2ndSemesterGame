using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ryft : MonoBehaviour {

    public KeyCode ryftButton = KeyCode.Mouse0;

    public List<GameObject> backgroundToChange;
    public Color red;
    public Color white;

    public List<GameObject> visibleInRed;
    public List<GameObject> visibleInWhite;

    private bool isRed = true;
    public int cooldown = 0;
    public int coolDownTime = 1000;

	// Use this for initialization
	void Start () {
        initColors();
        switchColors();
        showControl();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(ryftButton) && cooldown == 0) {
            isRed = !isRed;
            cooldown = coolDownTime;
            
            switchColors();
            showControl();
            

        }
        else if (cooldown > 0) {
            cooldown--;
        }
	
	}

    void initColors() {
        foreach (GameObject obj in visibleInRed) {
            if(obj.renderer != null)
            obj.renderer.material.color = red;
        }
        foreach (GameObject obj in visibleInWhite) {
            if (obj.renderer != null)
            obj.renderer.material.color = white;
        }
    }

    void switchColors() {
        foreach (GameObject obj in backgroundToChange) {
            if (isRed)
                obj.renderer.material.color = red;
            else {
                obj.renderer.material.color = white;
            }
        }
    }

    void showControl() {
        if (isRed) {
            show(visibleInRed, true);
            show(visibleInWhite, false);

        }
        else {
            show(visibleInRed, false);
            show(visibleInWhite, true);
        }
    }

    void show(List<GameObject> toShow, bool show) {
        foreach (GameObject obj in toShow) {
            obj.SetActive(show);
        }
    }
}
