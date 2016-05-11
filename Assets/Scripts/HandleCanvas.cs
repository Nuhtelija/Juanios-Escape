using UnityEngine;
using System.Collections;
using UnityEngine.UI;


/// <summary>
/// Scales canvas with screensize
/// </summary>
public class HandleCanvas : MonoBehaviour {

	private CanvasScaler scaler;
	
	void Start () {
		scaler = GetComponent<CanvasScaler> ();

		scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
	}
}
