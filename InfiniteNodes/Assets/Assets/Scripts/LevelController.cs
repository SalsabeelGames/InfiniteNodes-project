using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

	public LevelButton buton;
	public GameObject cv;
	void Start () {
		LevelButton b = Instantiate (buton);
		b.transform.position = new Vector3 ();
		b.transform.SetParent (cv.transform, false);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void clickLevel(int levelNumber){

	}
}
