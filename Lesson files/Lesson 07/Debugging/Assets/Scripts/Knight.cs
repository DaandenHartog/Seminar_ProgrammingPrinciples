using UnityEngine;

public class Knight : MonoBehaviour {

	private Orc orc;

	private void Start() {
		Debug.Log("Hallo ik ben een knight");

		orc = GameObject.Find("Orc").GetComponent<Orc>();
		if (orc == null) {
			return;
		}

		Debug.Log("De distance tussen mij en de orc is: " + CheckDistance());
	}

	private float CheckDistance(Orc orc = null) {
		float distance = Vector2.Distance(transform.position, orc.transform.position);
		return distance;
	}
}
