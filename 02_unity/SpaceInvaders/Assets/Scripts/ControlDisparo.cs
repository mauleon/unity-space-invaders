using UnityEngine;
using System.Collections;

public class ControlDisparo : MonoBehaviour
{

	// Conexión al marcador, para poder actualizarlo
	public GameObject marcador;

	// Por defecto, 100 puntos por cada alien
	public int puntos = -5;

	// Use this for initialization
	void Start ()
	{
		// Localizamos el objeto que contiene el marcador
		marcador = GameObject.Find ("Marcador");
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Eliminamos el objeto si se sale de la pantalla
		if (transform.position.y > 10) {
			marcador.GetComponent<ControlMarcador> ().puntos += puntos;	Destroy (gameObject);
		}	
	}
}
