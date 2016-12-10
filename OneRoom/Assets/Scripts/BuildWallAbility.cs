using UnityEngine;
using System.Collections;

public class BuildWallAbility : Ability {

    private GameObject wall;

    public BuildWallAbility()
    {
        energyCost = 10;
        wall = Resources.Load("PlayerWall") as GameObject;
    }

    public override bool use(GridPoint point, Direction dir)
    {
        GameObject.Instantiate(wall, GameObject.FindObjectOfType<Grid>().gridToWorld(point), Quaternion.identity);
        return true;
    }

	
}
