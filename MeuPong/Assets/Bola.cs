using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {
	public float Vel = 10;
	private Vector3 SenVel;
	
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		Debug.Log(rb.name);
		rb.velocity = Vector3.left * Vel;
	}
	
	// Update is called once per frame
	void Update () {
		SenVel = rb.velocity.normalized;
	}
	void OnCollisionEnter(Collision ou){
		if(ou.transform.tag == "Raquete"){
			var variacao = transform.position - ou.transform.position;
			rb.velocity = variacao.normalized * Vel;
			
		}else{
			var refletido = Vector3.Reflect(SenVel, ou.contacts[0].normal);
			rb.velocity = refletido.normalized * Vel;
		}
	}
	void OnTriggerEnter(Collider ou){
		if(ou.tag == "FundoDir") ponto(true);
			else if (ou.tag=="FundoEsq") ponto(false);
	}
	void ponto(bool isEsquerda){
		transform.position = Vector3.zero;
		if(isEsquerda) rb.velocity = Vector3.right * Vel;
		else rb.velocity = Vector3.left * Vel;
		
		
	}
}
