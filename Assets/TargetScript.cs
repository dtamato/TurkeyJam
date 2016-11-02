using UnityEngine;
using System.Collections;

[DisallowMultipleComponent]
public class TargetScript : MonoBehaviour {

	[SerializeField] GameObject successAudioPrefab;


	void OnMouseDown () {

		this.GetComponentInChildren<MeshRenderer> ().enabled = false;
		if (successAudioPrefab) { Instantiate (successAudioPrefab, this.transform.position, Quaternion.identity); }
		Destroy (this.gameObject);
	}
}
