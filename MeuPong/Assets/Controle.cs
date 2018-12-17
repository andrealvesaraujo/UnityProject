using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour {
	public bool CimaBaixo;
	public float Velocidade = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	if(CimaBaixo){
		if (Input.GetKey(KeyCode.UpArrow)) transform.position += Vector3.up * Velocidade;
		if (Input.GetKey(KeyCode.DownArrow)) transform.position += Vector3.down * Velocidade;
	}else{
		if (Input.GetKey(KeyCode.W)) transform.position += Vector3.up * Velocidade;
		if (Input.GetKey(KeyCode.S)) transform.position += Vector3.down * Velocidade;
		
	}
	}
}
