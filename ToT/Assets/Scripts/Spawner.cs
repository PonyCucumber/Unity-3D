using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform Position;
    public GameObject CharacterPrefab;
    // Start is called before the first frame update
    void Start()
    {
        var ch = Instantiate(CharacterPrefab, Position.position, Quaternion.identity);
    }

    
}
