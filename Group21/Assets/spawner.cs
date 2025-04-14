using UnityEngine;

public class spawner : MonoBehaviour
{


public GameObject myCube;

public void SpawnCube()
{
Instantiate(myCube);
}


}