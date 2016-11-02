using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[DisallowMultipleComponent]
public class OrientationTests : MonoBehaviour {

	Text outputText;
	Compass myCompass;

	void Awake () {

		if (SystemInfo.deviceType == DeviceType.Handheld) {

			if (Input.location.isEnabledByUser) {

				outputText = this.GetComponentInChildren<Text> ();
				Input.location.Start ();
				myCompass = Input.compass;
				myCompass.enabled = true;
			}
		}
	}

	void Update () {

		if(SystemInfo.deviceType == DeviceType.Handheld) {

			outputText.text =
				"Acceleration: " + Input.acceleration + "\n" +
				"Magnetic Heading: " + myCompass.magneticHeading + "\n" +
				"gyro acceleration: " + Input.gyro.userAcceleration +
				"Raw Vector: " + myCompass.rawVector;
		}
	}
}
