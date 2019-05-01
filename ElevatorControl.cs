using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorControl : MonoBehaviour {

    public GameObject elevator;
    private Vector3 elevatorOrigin;
    private bool playerOn;

	// Use this for initialization
	void Start () {
        elevatorOrigin = elevator.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (playerOn == false && transform.position.y > elevatorOrigin.y + 2) {
            elevator.transform.position -= elevator.transform.up * Time.deltaTime;
        }
  
    }

    private void OnTriggerStay(Collider other) {
        if (other.tag.Equals("Player")) {
            playerOn = true;
            elevator.transform.position += elevator.transform.up * Time.deltaTime;
        }
    }

    private void OnTriggerExit(Collider other) {
        playerOn = false;
    }
}
