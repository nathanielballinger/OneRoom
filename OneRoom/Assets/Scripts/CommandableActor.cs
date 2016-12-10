using UnityEngine;
using System.Collections;

public abstract class CommandableActor : MonoBehaviour, ICommandable {

    protected GridPoint position;
    protected float energy;


    public bool moveTo(GridPoint point)
    {
        return false;
    }

    public abstract bool useAbility(GridPoint point, Direction dir, Ability ability);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
