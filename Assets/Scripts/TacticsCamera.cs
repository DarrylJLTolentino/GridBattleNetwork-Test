using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TacticsCamera : MonoBehaviour
{
	public Button leftButton;
	public Button rightButton;
	public bool lPressed = false;
	public bool rPressed = false;

	public void leftButtonPressed()
	{
		lPressed = true;
	}

	public void rightButtonPressed()
	{
		rPressed = true;
	}

	void Update()
	{
//		RotateLeft()
//			{	
//			//transform.Rotate(Vector3.up, 90, Space.Self);
//			//transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime * speed);
//
//			{
//				StartCoroutine(Rotate(Vector3.up, 90, Space.Self));
//			}
//		
//			IEnumerator Rotate(Vector3 axis, float angle, turnSpeed)
//			{
//				Quaternion intialCameraAngle = transform.rotation;
//				Quaternion nextCameraAngle = transform.rotation;
//				nextCameraAngle *= Quaternion.Euler(axis * angle);
//
//				float timeElapsed = 0.0f;
//				while(timeElapsed < turnSpeed)
//				{
//					transform.rotation = Quaternion.Slerp(intialCameraAngle
//				}
//			}

		if (lPressed == true) {
			RotateLeft ();
			lPressed = false;
		} else if (rPressed == true) {
			RotateRight ();
			rPressed = false;
		} 
		else {
			return;
		}
			
	}

	public void RotateLeft()
	{
		StartCoroutine (RotateLeftButton (Vector3.up, 90, 1.0f));
	}

	IEnumerator RotateLeftButton(Vector3 axis, float angle, float turnSpeed = 1f)
	{
		Quaternion initialCameraAngle = transform.rotation;
		Quaternion nextCameraAngle = transform.rotation;
		nextCameraAngle *= Quaternion.Euler(axis * angle);

		float timeElapsed = 0.0f;
		while (timeElapsed < turnSpeed)
		{
			transform.rotation = Quaternion.Slerp(initialCameraAngle, nextCameraAngle, timeElapsed / turnSpeed);
			timeElapsed += Time.deltaTime;
			yield return null;
		}
		transform.rotation = nextCameraAngle;
		StopAllCoroutines ();
	}

//		public void RotateRight()
//		{
//			//transform.Rotate(Vector3.up, -90, Space.Self);
//			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, -90, 0), Time.deltaTime * speed);
//		}
//
//	}

	public void RotateRight()
	{
		StartCoroutine (RotateRightButton (Vector3.up, -90, 1.0f));
	}

	IEnumerator RotateRightButton(Vector3 axis, float angle, float turnSpeed = 1f)
	{
		Quaternion initialCameraAngle = transform.rotation;
		Quaternion nextCameraAngle = transform.rotation;
		nextCameraAngle *= Quaternion.Euler(axis * angle);

		float timeElapsed = 0.0f;
		while (timeElapsed < turnSpeed)
		{
			transform.rotation = Quaternion.Slerp(initialCameraAngle, nextCameraAngle, timeElapsed / turnSpeed);
			timeElapsed += Time.deltaTime;
			yield return null;
		}
		transform.rotation = nextCameraAngle;
		StopAllCoroutines ();
	}

}
