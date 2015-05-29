using UnityEngine;
using System.Collections;

public class BoxScript : MonoBehaviour {

	public GameObject explosion;

	// Use this for initialization
	void Start () {
		GameObject otherObject = GameObject.Find("l2c1");
		otherObject.renderer.material.color = Color.green;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void OnMouseDown() {
		if(gameObject.renderer.material.color == Color.green)
		{
			Instantiate (explosion, transform.position, transform.rotation);
			Destroy (gameObject);
			PlaneScripts.box ++;
			if (PlaneScripts.box == 10) {
				PlaneScripts.box = 1;
				PlaneScripts.level--;
			}

			GameObject otherObject = new GameObject();
			switch (PlaneScripts.level) {
			case 1:
				switch(PlaneScripts.box){
				case 1:
					otherObject = GameObject.Find("l1c1");
					break;
				case 2:
					otherObject = GameObject.Find("l1c2");
					break;
				case 3:
					otherObject = GameObject.Find("l1c3");
					break;
				case 4:
					otherObject = GameObject.Find("l1c4");
					break;
				case 5:
					otherObject = GameObject.Find("l1c5");
					break;
				case 6:
					otherObject = GameObject.Find("l1c6");
					break;
				case 7:
					otherObject = GameObject.Find("l1c7");
					break;
				case 8:
					otherObject = GameObject.Find("l1c8");
					break;
				case 9:
					otherObject = GameObject.Find("l1c9");
					break;
				}
				break;
			case 2:
				switch(PlaneScripts.box){
				case 1:
					otherObject = GameObject.Find("l2c1");
					break;
				case 2:
					otherObject = GameObject.Find("l2c2");
					break;
				case 3:
					otherObject = GameObject.Find("l2c3");
					break;
				case 4:
					otherObject = GameObject.Find("l2c4");
					break;
				case 5:
					otherObject = GameObject.Find("l2c5");
					break;
				case 6:
					otherObject = GameObject.Find("l2c6");
					break;
				case 7:
					otherObject = GameObject.Find("l2c7");
					break;
				case 8:
					otherObject = GameObject.Find("l2c8");
					break;
				case 9:
					otherObject = GameObject.Find("l2c9");
					break;
				}
				break;
			}
			otherObject.renderer.material.color = Color.green;
			//Debug.Log (otherObject.transform.Translate);
		}		
	}

}
