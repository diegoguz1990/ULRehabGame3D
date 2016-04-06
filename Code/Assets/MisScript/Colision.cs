using UnityEngine;
using System.Collections;

public class Colision : MonoBehaviour {

    public GameObject Boom;

	// Use this for initialization
	void Start () {
        Boom.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        Boom.SetActive(true);
        Destroy(gameObject, 1);
        Debug.Log("Ha golpeado un globo");
    }
}
