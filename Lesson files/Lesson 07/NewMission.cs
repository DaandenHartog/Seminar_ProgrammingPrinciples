using UnityEngine;
using System.Collections;

public class NewMission : MonoBehaviour, IMission {

	public bool missionComplete { get; set; }

	private float timer;

	void Start () {
		StartMission ();
	}

	void Update () {
		if (missionComplete)
			return;

		UpdateMission ();
	}
	
	public void StartMission () {
		Debug.Log ("Start mission");
	}

	public void UpdateMission () {
		timer += Time.deltaTime;

		Debug.Log ("Updating mission");

		if (timer > 10f) {
			EndMission();
			missionComplete = true;
		}
	}

	public void EndMission () {
		Debug.Log ("Jeej you did it, you waited for 10 seconds!");
	}
}