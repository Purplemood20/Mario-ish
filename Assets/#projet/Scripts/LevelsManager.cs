using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsManager : MonoBehaviour
{
    static LevelsManager instance = null;
    public GameObject playerPrefab;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        // si change valeur d'une variable statique, elle est changée pour ttes les classes
        if(instance == null)
        {
            DontDestroyOnLoad(gameObject); // en minuscule game object sur lequel est le script
            instance = this;
            player = Instantiate(playerPrefab);
            DontDestroyOnLoad(player);
        }
        else
        {
            Destroy(gameObject);   // système de singleton-> il ne peut y en avoir qu'un seul qui reste celui de la 1ère scène
        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
