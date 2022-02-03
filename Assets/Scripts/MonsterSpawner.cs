using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] monsterReference;

    private GameObject spawnedMonster;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnMonsters());
    }

    IEnumerator spawnMonsters() {

        while(true){

        yield return new WaitForSeconds(Random.Range(1, 5));

        randomIndex = Random.Range(0, monsterReference.Length);
        randomSide = Random.Range(0, 2);

        spawnedMonster = Instantiate(monsterReference[randomIndex]);

        if(randomSide == 0) {

            spawnedMonster.transform.position = leftPos.position;
            spawnedMonster.GetComponent<Monster>().speed = Random.Range(4, 10);

            // //setting sorting layer to "Player"
            // spawnedMonster.GetComponent<SpriteRenderer>().sortingLayerName = "Player";

            // //transforming position to spawn on z = 0
            // spawnedMonster.transform.position = new Vector3(spawnedMonster.transform.position.x, spawnedMonster.transform.position.y, 0);

        }
        else{

            spawnedMonster.transform.position = rightPos.position;
            spawnedMonster.GetComponent<Monster>().speed = -Random.Range(4, 10);

            // //setting sorting layer to "Player"
            //  spawnedMonster.GetComponent<SpriteRenderer>().sortingLayerName = "Player";

            //transforming scale for x = -x 
            spawnedMonster.transform.localScale = new Vector3(-spawnedMonster.transform.localScale.x, spawnedMonster.transform.localScale.y, spawnedMonster.transform.localScale.z);
            
            // //transforming position to spawn on z = 0
            // spawnedMonster.transform.position = new Vector3(spawnedMonster.transform.position.x, spawnedMonster.transform.position.y, 0);
        }
        }// while 

    }
} //class
