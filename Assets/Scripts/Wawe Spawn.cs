using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaweSpawn : MonoBehaviour {
	
	public int Wavesize;

	public GameObject EnemyPrefab;

	public float EnemyInterval;

	public Transform spawnPoint;

	public float startTime;

	int enemyCount = 0;

	public Transform[] Way;

	void Start () {
		InvokeRepeating ("SpawnEnemy",startTime,EnemyInterval);
	}
	

	void Update () {
		if(enemyCount == Wavesize)
		{
			CancelInvoke("SpawnEnemy");
		}
	}

	void SpawnEnemy () {

		GameObject enemy = GameObject.Instantiate (EnemyPrefab,spawnPoint.position,Quaternion.identity) as GameObject;
		enemy.GetComponent<MovingWay> ().Waypoints = Way;
	}

}

