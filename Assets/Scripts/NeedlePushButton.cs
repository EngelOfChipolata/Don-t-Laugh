using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedlePushButton : MonoBehaviour {

	public Needle needle;
	public enum EDirection {POSITIVE, NEGATIVE} ;
	public EDirection direction;
	public float rotationStep;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(0))
		{
			int sign = (int)direction == 1 ? 1 : -1;
			needle.gameObject.transform.Rotate (0, 0, sign * rotationStep);
		}
	}
}
