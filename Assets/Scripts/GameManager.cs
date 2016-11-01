using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	public Transform originalPathmaker;
	// Use this for initialization
	void Start () {
		
		Instantiate (originalPathmaker, new Vector3 (0, 0, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
