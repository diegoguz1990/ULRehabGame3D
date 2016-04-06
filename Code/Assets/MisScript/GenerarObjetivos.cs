using UnityEngine;
using System.Collections;

public class GenerarObjetivos : MonoBehaviour {

    public Transform[] PuntoAparicion;
    public float tiempoAparicion = 5.0f;

    public GameObject Objetivo;
    //public GameObject[] Objetivos;


    // Use this for initialization
    void Start ()
    {
        //GetComponent<Renderer>() .material.color = new Color(0, 0, 0);
        InvokeRepeating("Aparecer", tiempoAparicion, tiempoAparicion);
    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    void Aparecer()
    {
        int indiceAparecer = Random.Range(0, PuntoAparicion.Length);
        Instantiate(Objetivo, PuntoAparicion[indiceAparecer].position, PuntoAparicion[indiceAparecer].rotation);
    }
}
