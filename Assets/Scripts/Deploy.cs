using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deploy : MonoBehaviour
{
    private Vector2 screenBounds;
    public GameObject notePrefab;
    public float respawnTime = 1.0f;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(noteWave());
    }
    
    private void spawnNote()
    {
        GameObject a = Instantiate(notePrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator noteWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnNote();
        }
    }
}
