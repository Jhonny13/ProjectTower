using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWay : MonoBehaviour {

	public float Speed;

	public Transform[] Waypoints; 

	int curWaypoint = 0;


	

	void Update () {
		if(curWaypoint < Waypoints.Length){
		
			transform.position = Vector3.MoveTowards  (transform.position, Waypoints [curWaypoint], Time.deltaTime * Speed);
					transform.LookAt(Waypoints[curWaypoint]);
					if(Vector3.Distance(transform.position,Waypoints[curWaypoint].position < 0.5f)){
						
						curWaypoint++;
	}
	}
	}
}
