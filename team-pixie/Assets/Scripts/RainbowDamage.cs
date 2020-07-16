using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RainbowDamage : MonoBehaviour
{
    [SerializeField] private float newalpha;

    public Image rainbowdmg;
    // Start is called before the first frame update

    PlayerHealth player;
    void Start()
    {
        player = FindObjectOfType<PlayerHealth>();
        GetComponent<Image>().color = new Color ( 255, 255, 255, 0 );
    }

    private float HealthConversion()
    {
         return (float) (1 - (0.01 * (player.Health)));
    }
    private void HealthAlpha()
    {
        newalpha = (float)HealthConversion();
        GetComponent<Image>().color = new Color(255, 255, 255, newalpha);
    }
 
    // Update is called once per frame
    void Update()
    {
        HealthAlpha();
    }
}
