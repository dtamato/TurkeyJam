using UnityEngine;
using System.Collections;

[DisallowMultipleComponent]
public class DestroySelf : MonoBehaviour {

	[SerializeField] float destroyTime = 1;

	// Use this for initialization
	void Start () {
	
		Destroy (this.gameObject, destroyTime);
	}
}
