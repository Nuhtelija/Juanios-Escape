using UnityEngine;
using System.Collections;
/// <summary>
/// This rotates the object at given speed around a given point
/// </summary>
public class SwingScript : MonoBehaviour {

    public GameObject rotatePoint;

    public float speed;
    private float currentAngle;
    
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        currentAngle = speed * Time.deltaTime;
        gameObject.transform.RotateAround(rotatePoint.transform.position, Vector3.forward, currentAngle   );

	}
}
