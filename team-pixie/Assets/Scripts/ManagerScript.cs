using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScript : MonoBehaviour
{
    System.Random rand = new System.Random();
    [SerializeField] UnityEngine.Object Phone;
    [SerializeField] UnityEngine.Object Key;
    [SerializeField] UnityEngine.Object Wallet;

    [SerializeField] Vector3 PhonePosition1;
    [SerializeField] Vector3 PhonePosition2;
    [SerializeField] Vector3 PhonePosition3;

    [SerializeField] Vector3 KeyPosition1;
    [SerializeField] Vector3 KeyPosition2;
    [SerializeField] Vector3 KeyPosition3;

    [SerializeField] Vector3 WalletPosition1;
    [SerializeField] Vector3 WalletPosition2;
    [SerializeField] Vector3 WalletPosition3;

    void Start()
    {
        RandomizedSpawner();
    }


    void RandomizedSpawner()
    {
        int x;

        x = rand.Next(1,4);

        switch (x)
        {
            case 1:
                Instantiate(Wallet, WalletPosition1, Quaternion.identity);
                Instantiate(Phone, PhonePosition1, Quaternion.identity);
                Instantiate(Key, KeyPosition1, Quaternion.identity);
                break;
            case 2:
                Instantiate(Wallet, WalletPosition2, Quaternion.identity);
                Instantiate(Phone, PhonePosition2, Quaternion.identity);
                Instantiate(Key, KeyPosition2, Quaternion.identity);
                break;
            case 3:
                Instantiate(Wallet, WalletPosition3, Quaternion.identity);
                Instantiate(Phone, PhonePosition3, Quaternion.identity);
                Instantiate(Key, KeyPosition3, Quaternion.identity);
                break;
            default:
                Debug.Log("Error");
                Application.Quit();
                break;
        }
    }



    public void GameOver()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Game has Ended");
    }
}
