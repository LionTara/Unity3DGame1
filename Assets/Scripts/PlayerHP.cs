using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public int HP = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void damage(int damage)
    {
        // HP = HP - damage 
        // HP = 100 - 20
        // HP = 80

        HP -= damage;
        if (HP < 0 ) { HP = 0; }
        if (HP ==  0 )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
