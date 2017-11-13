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
		animator.Play (type.ToString ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
