using UnityEngine;
using System.Collections;

public class Rotacion : MonoBehaviour {

    public int VelRota = 10;

	// Use this for initialization
	void Start () {
        transform.Rotate(new Vector3(45, 45, 0));
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0f, VelRota, 0f) * Time.deltaTime);
    }

}
