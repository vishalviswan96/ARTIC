using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetSpawn : MonoBehaviour
{
    public GameObject target;
    public GameObject boxTarget;
    public Button varifiedButton;

    // Use this for initialization
    void Start()
    {

        varifiedButton.onClick.AddListener(StartInvoke);

    }

    public void StartInvoke()
    {

        //repete in each sec(method, start time, spawn intervel)
        InvokeRepeating("SpawnMan", 3f, 4f);
        InvokeRepeating("BoxSpawn", 6f, 3f);
    }

    void SpawnMan()
    {
        //random position of enemy
        Vector3 position = new Vector3(Random.Range(-5f, 5f), 0.3f, Random.Range(-5f, 5f));

        //generate obj, pos, rotation of enemy
        Instantiate(target, position, Quaternion.Euler(180, 0, 0));
    }

    void BoxSpawn()
    {
        Vector3 position = new Vector3(Random.Range(-5f, 5f), 0.3f, Random.Range(-5f, 5f));
        Instantiate(boxTarget, position, Quaternion.Euler(0, 0, 0));
    }
}
