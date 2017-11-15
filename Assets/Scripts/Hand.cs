using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {
	[SerializeField]
	FingerspellingType type;
	Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponentsInChildren<Animator>(true)[0];
		StartCoroutine (Init ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Init() {
		yield return null;
		yield return null;
		animator.Play (type.ToString (), 0, 0.9f);
		animator.speed = 0;
	}
}
