using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PathFinder : MonoBehaviour {

	static int Total_Num_Of_Tiles;
	static int Total_Num_Of_Pathmakers;
	public int totalTilesZero;
	public int totalPathsZero;
	private int counter = 0;
	public Transform Floor_Prefab;
	public Transform Pathmaker_Sphere_Prefab;
	bool newPathFinder = false;

	int rand_Pathmakers_Num;
	// Use this for initialization
	void Start () {
		Total_Num_Of_Tiles = totalTilesZero;
		//Total_Num_Of_Pathmakers = totalPathsZero;
		rand_Pathmakers_Num = Random.Range (1, 2);
	}
	
	// Update is called once per frame
	void Update () {
		totalTilesZero = Total_Num_Of_Tiles;
		totalPathsZero = Total_Num_Of_Pathmakers;
		if (counter <= 50 && Total_Num_Of_Tiles < 1000 ) {
			float Random_Num = Random.Range (0.0f, 1.0f);
			if (Random_Num <= 0.25f) {
				transform.Rotate (new Vector3 (0, 90f, 0));
			} else if (Random_Num > 0.25f && Random_Num <= 0.5f) {
				transform.Rotate (new Vector3 (0, -90f, 0));
			} else if (Random_Num > 0.8f && Total_Num_Of_Pathmakers < rand_Pathmakers_Num){ //0.99f && Random_Num <= 1.0f) {
				Instantiate (Pathmaker_Sphere_Prefab, transform.position, Quaternion.identity);
				Total_Num_Of_Pathmakers += 1;
			}
			Instantiate (Floor_Prefab, transform.position, Quaternion.identity);
			transform.position += transform.forward * 22.3f;
			counter += 1;
			Total_Num_Of_Tiles += 1;
		} else {
			
			Destroy (this.gameObject);
			
			Total_Num_Of_Pathmakers -= 1;
			Debug.Log(Total_Num_Of_Tiles);
		}


	}
}
