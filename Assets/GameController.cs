using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[DisallowMultipleComponent]
public class GameController : MonoBehaviour {

	[SerializeField] GameObject[] cubePrefabsArray;

	float spawnTimer = 3f;
	float distanceFromCenter = 7;

	void Start () {

		StartCoroutine (InstantiateNewCube ());
	}

	IEnumerator InstantiateNewCube () {

		float randomAngle = Random.Range (0f, 2 * Mathf.PI);

		float newX = distanceFromCenter * Mathf.Cos(randomAngle);
		float newZ = distanceFromCenter * Mathf.Sin (randomAngle);

		GameObject newCube = Instantiate (cubePrefabsArray [Random.Range (0, cubePrefabsArray.Length)], new Vector3(newX, -5f, newZ), Quaternion.identity) as GameObject;
		newCube.GetComponent<Rigidbody> ().AddForceAtPosition (600 * Vector3.up, -this.transform.up);
		//Debug.Log ("Instantiated new cube");

		yield return new WaitForSeconds (spawnTimer);

		StartCoroutine (InstantiateNewCube ());
	}
}
