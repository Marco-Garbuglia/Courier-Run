using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float spawnTimer; //spawn tempo tra un Ostacoli e un'altro
    float spawnRateOstacoli = 3f;
    float spawnRateOstacoloSu = 3f;
    float spawnRateGiù = 3f;
    public GameObject ostacolo; //due tubi sulla stessa veritcale
    public GameObject ostacolosu; 
    public GameObject ostacologiù; 
    public static bool gameover;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(!gameover) //nonserve GameController.gameover perchè sono nello script GameController
        {
            spawnTimer += Time.deltaTime; // ad ogni frame sommo a spawnTimer la durata del frame appena trascorso
            if (spawnTimer >= spawnRateOstacoli)
            {
                spawnTimer -= spawnRateOstacoli;
                Vector2 spawnPos = new Vector2(2f, Random.Range(-1f, 1f)); //12f perchè distamza tra Ostacoli e Ultimo ostacolo, 1f di altezza perchè altrimenti non arrivo con il courier
                Instantiate(ostacolo, spawnPos, Quaternion.identity);
                //Instantiate(ostacolosu, spawnPos, Quaternion.identity);
                //Instantiate(ostacologiù, spawnPos, Quaternion.identity);
            }
            if (spawnTimer >= spawnRateOstacoloSu)
            {
                spawnTimer -= spawnRateOstacoloSu;
                Vector2 spawnPos = new Vector3(10f, Random.Range(-1f, 1f)); //12f perchè distamza tra Ostacoli e Ultimo ostacolo, 1f di altezza perchè altrimenti non arrivo con il courier
                //Instantiate(ostacolo, spawnPos, Quaternion.identity);
                Instantiate(ostacolosu, spawnPos, Quaternion.identity);
                //Instantiate(ostacologiù, spawnPos, Quaternion.identity);
            }
            if (spawnTimer >= spawnRateGiù)
            {
                spawnTimer -= spawnRateGiù;
                Vector2 spawnPos = new Vector4(6f, Random.Range(-1f, 1f)); //12f perchè distamza tra Ostacoli e Ultimo ostacolo, 1f di altezza perchè altrimenti non arrivo con il courier
                //Instantiate(ostacolo, spawnPos, Quaternion.identity);
                //Instantiate(ostacolosu, spawnPos, Quaternion.identity);
                Instantiate(ostacologiù, spawnPos, Quaternion.identity);
            }
        }
    }
}
