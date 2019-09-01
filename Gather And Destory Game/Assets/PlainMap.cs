using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlainMap : Map {
    public CubeFactory cubeFactory;

    public int radius;
    Vector2Int Size => Vector2Int.one * (radius * 2 + 1);
    Vector3 CentreOffset => new Vector3(Size.x / 2f - .5f, 0, Size.y / 2f - .5f);

    public GameObject cube;
    [HideInInspector]
    public List<GameObject> cubeMap;



    void Awake() {
        cubeMap = new List<GameObject>();
    }

    void Start() {
        Create();
    }

    public override void Create() {

        for (int y = 0; y < Size.y; y++) {
            for (int x = 0; x < Size.x; x++) {
                GameObject newC = cubeFactory.GetCubeBy(CubeType.Ether, transform);
                newC.transform.localPosition = new Vector3(x, 0, y) - CentreOffset;

                cubeMap.Add(newC);
            }
        }
    }


}
