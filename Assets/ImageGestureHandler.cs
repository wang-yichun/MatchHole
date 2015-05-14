using UnityEngine;
using System.Collections;
using System;
using TouchScript.Gestures;
using TouchScript.Hit;

public class ImageGestureHandler : MonoBehaviour {

	void OnEnable ()
	{
		GetComponent<TapGesture> ().Tapped += tappedHandler;
	}
	
	void OnDisable ()
	{
		GetComponent<TapGesture> ().Tapped -= tappedHandler;
	}

	void tappedHandler (object sender, EventArgs e)
	{
		Vector2 res = new Vector2 ();
		ITouchHit hit;
		(sender as TapGesture).GetTargetHitResult(out hit);
		ITouchHit2D hit2d = hit as ITouchHit2D;

		Debug.Log (hit2d.Point);
	}
}
