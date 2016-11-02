using UnityEngine;
using System.Collections;

// TODO:
// - Instead of hardsetting the compass's angle to the camera's angle. Have it smoothly lerp to it so
//		to avoid sudden and disorienting shifts

[DisallowMultipleComponent]
public class RotateCamera : MonoBehaviour {

	Compass myCompass;

	void Awake () {

		if (SystemInfo.deviceType == DeviceType.Handheld) {

			Input.location.Start ();
			myCompass = new Compass ();
			myCompass.enabled = true;
		}
	}

	void Update () {

		if (SystemInfo.deviceType == DeviceType.Handheld) {

			if (myCompass.enabled) {

				this.transform.eulerAngles = new Vector3 (0, myCompass.magneticHeading, 0);
			}
		}
	}
}
