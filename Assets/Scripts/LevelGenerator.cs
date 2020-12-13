using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public int numberOfPlatform;           
    float minY = .8f;
    float maxY = 1.5f;
    float levelWidth = 4.5f;

    void Start()
    {
        Vector3 spawnPosition = new Vector3(0,-2,0);     //spawn işleminin başlangıç pozisyonu
        for(int i=0; i < numberOfPlatform; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);       //Dikeyde spawn ediyoruz. += yapmaya dikkat edelim
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);    //Yatayda level sınırlarını belirledik
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
        
    }
}
