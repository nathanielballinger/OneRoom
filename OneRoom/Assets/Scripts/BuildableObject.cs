using UnityEngine;
using System.Collections;

public abstract class BuildableObject : MonoBehaviour {

    Grid grid;
	// Use this for initialization
	public virtual void Start () {
        grid = GameObject.FindObjectOfType<Grid>();
        grid.addToGrid(gameObject);

	}
	
	// Update is called once per frame
	public virtual void Update () {

	}
}
