
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
 {

    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 40;

    [SerializeField] private Transform levelPart_Start;
    [SerializeField] private List<Transform> levelPartList;
    [SerializeField] private Player player;

    [SerializeField] private Vector3 lastEndPosition;

    Transform currentLevel;

    private void Awake() 
    {
        lastEndPosition = levelPart_Start.Find("Ground").Find("EndPosition").position;

        currentLevel = levelPart_Start;

        int startingSpawnLevelParts = 1;
        for (int i = 0; i < startingSpawnLevelParts; i++)
        {
            SpawnLevelPart();
        }
    }

    private void Update()

    {
        lastEndPosition = currentLevel.Find("Ground").Find("EndPosition").position;
        if(Vector3.Distance(player.GetComponent<Player>().GetPositionPlayer, lastEndPosition ) < PLAYER_DISTANCE_SPAWN_LEVEL_PART)
        {
            SpawnLevelPart();
        }
    }

    private void SpawnLevelPart() 
    {
        Transform chosenLevelPart = levelPartList[Random.Range(0, levelPartList.Count)];
        Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition);
        currentLevel = lastLevelPartTransform;
    }

    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition) 
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }

}
