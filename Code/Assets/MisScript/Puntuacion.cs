using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {

    public int Puntos = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider other)
    {
        //if(other.tag == "Objetivo")
        //{
            Puntos++;
            Debug.Log("Aumenta el puntaje");
            //Destroy(other.gameObject);
        //}
    }

    // OnGUI
    void OnGUI()
    {
        Rect rectObj = new Rect(40, 10, 200, 400);
        GUIStyle style = new GUIStyle();
        style.alignment = TextAnchor.UpperLeft;
        GUI.Box(rectObj, "Puntaje: " + Puntos + "\n", style);
    }
}
