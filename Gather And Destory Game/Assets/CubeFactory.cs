using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CubeFactory : ScriptableObject {
    [SerializeField] List<GameObject> cubeList;

    public GameObject GetCubeBy(CubeType cType) {
        GameObject newCube = Instantiate(cubeList[(int)cType]);
        return newCube;
    }

    public GameObject GetCubeBy(CubeType cType, Transform parent) {
        GameObject newCube = Instantiate(cubeList[(int)cType], parent);
        return newCube;
    }
}