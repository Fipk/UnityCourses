using UnityEngine;

public class AllWeapons : MonoBehaviour
{
    public FirstScriptableObject weapon;
    public int score = 1;
    public int retrieveScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Nom: {weapon.name}");
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerPrefs.SetInt("Score Player", score);
            PlayerPrefs.Save();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            retrieveScore = PlayerPrefs.GetInt("Score Player");
            Debug.Log($"Score récupérer: {retrieveScore}");
        }
    }
}
