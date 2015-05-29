using UnityEngine;
using System.Collections;

public class balonScript : MonoBehaviour {
	private float creatingTime=0;
	// Use this for initialization
	void Start () {
		creatingTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(0.9f, 0.9f, 0.9f), Time.deltaTime);
		if (Time.time - creatingTime > 3)
						Destroy (gameObject);
	}
}
