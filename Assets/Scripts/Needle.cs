using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Needle : MonoBehaviour {
	private float neutralAngle;
	public float gravityFactor;

	// Use this for initialization
	void Start () {
		neutralAngle = this.gameObject.transform.localEulerAngles.z;
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs(this.gameObject.transform.eulerAngles.z - neutralAngle) <= 0.005) {
			int sign = Math.Sign(UnityEngine.Random.Range (-1, 2));
			this.gameObject.transform.Rotate (0, 0, sign * 0.05f);
		}
		this.gameObject.transform.Rotate (0,0, (float)Math.Sin((this.gameObject.transform.eulerAngles.z - neutralAngle) * Math.PI / 180f)*gravityFactor);

		if (Mathf.Abs (this.gameObject.transform.eulerAngles.z - neutralAngle) >= 90) {
			//DestroyObject (this);
		}
	}
}
