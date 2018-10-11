using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Player : MonoBehaviour {

	private Rigidbody2D rb;

	public float moveSpeed = 500.0f;

	private float movement = 0.0f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		movement = Input.GetAxisRaw("Horizontal");
	}

	void FixedUpdate() {
		rb.transform.RotateAround(Vector3.zero, Vector3.forward, -movement * Time.deltaTime * moveSpeed );
	}

	void OnTriggerEnter2D(Collider2D collision) {
		EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex);
	}
}
