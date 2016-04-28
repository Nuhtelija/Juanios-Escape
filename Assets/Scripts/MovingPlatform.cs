using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	public GameObject platform;

	public float moveSpeed;

	private Transform currenPoint;

	public Transform[] points;

	public int pointSelection;

	// Use this for initialization
	void Start () {

		currenPoint = points [pointSelection];
	
	}
	
	// Update is called once per frame
	void Update () {

		platform.transform.position = Vector3.MoveTowards (platform.transform.position, currenPoint.position, Time.deltaTime * moveSpeed);

		if (platform.transform.position == currenPoint.position) {

			pointSelection++;

			if (pointSelection == points.Length) {

				pointSelection = 0;
			}

			currenPoint = points [pointSelection];
		}
	
	}
}
