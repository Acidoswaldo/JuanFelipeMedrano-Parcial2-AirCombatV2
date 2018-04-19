using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//mover hacia adelante
		this.transform.Translate (0.0f, 0.0f, 8.0f);

	}

	void OnCollisionEnter(Collision collision) { 

		if (collision.collider.gameObject.tag == "JupiterAlien") {
			

			//Cargo el prefab de una explosion
			GameObject Explosion = GameObject.Instantiate (Resources.Load ("Prefabs/JupiterExplosion") as GameObject);
			Explosion.transform.position = collision.collider.gameObject.transform.position;



			//Eliminamos el piso
			Destroy (collision.collider.gameObject);
			//Eliminamos el misil
			Destroy (this.gameObject);


		}

		if (collision.collider.gameObject.tag == "MarsAlien") {


			//Cargo el prefab de una explosion
			GameObject Explosion = GameObject.Instantiate (Resources.Load ("Prefabs/MarsExplosion") as GameObject);
			Explosion.transform.position = collision.collider.gameObject.transform.position;



			//Eliminamos el piso
			Destroy (collision.collider.gameObject);
			//Eliminamos el misil
			Destroy (this.gameObject);


		}

		if (collision.collider.gameObject.tag == "NeptuneAlien") {


			//Cargo el prefab de una explosion
			GameObject Explosion = GameObject.Instantiate (Resources.Load ("Prefabs/NeptuneExplosion") as GameObject);
			Explosion.transform.position = collision.collider.gameObject.transform.position;



			//Eliminamos el piso
			Destroy (collision.collider.gameObject);
			//Eliminamos el misil
			Destroy (this.gameObject);


		}

		if (collision.collider.gameObject.tag == "Amigo") {
			//GameObject Explosion = GameObject.Instantiate (Resources.Load ("Prefabs/Explosion") as GameObject);
			//Explosion.transform.position = collision.collider.gameObject.transform.position;
			GameObject son = collision.collider.gameObject.transform.Find("LuzVerde").gameObject;

			son.GetComponent<Light> ().color = new Color (0, 0, 1);

			Destroy (this.gameObject);
		}

	}
		

}
