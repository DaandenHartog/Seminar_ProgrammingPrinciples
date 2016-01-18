using UnityEngine;
using System.Collections;

public interface IMission {

	bool missionComplete { get; set; }

	void StartMission();

	void UpdateMission();

	void EndMission();

}