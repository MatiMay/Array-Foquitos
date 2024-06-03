using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoquitoScript : MonoBehaviour
{
    [SerializeField] GameObject[] colors;
    public int currentLightIndex =-1;
    int Contciclo=0;
    public int LimCiclo = 3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateNextLight()
    {
        if (ContCiclo < LimCiclo)
        {
            currentLightIndex++;
            if (currentLightIndex >= colors.Length)
            {
                currentLightIndex = 0;
                ContCiclo++;
                Debug.Log(ContCiclo);
                if (ContCiclo >= LimCiclo)
                {
                    Destroy(colors[currentLightIndex]);
                }
            }
            if (colors[0] != null)
            {
                DeactivateAllLights();
                colors[currentLightIndex].SetActive(true);
            }
        }
    }

    public void ActivatePreviousLight()
    {
        if (ContCiclo < LimCiclo)
        {
            currentLightIndex--;
            if (currentLightIndex < 0)
            {
                currentLightIndex = colors.Length - 1;
                ContCiclo++;
                Debug.Log(ContCiclo);
                if (ContCiclo >= LimCiclo)
                {
                    Destroy(colors[currentLightIndex]);
                }
            }
            if (colors[0] != null)
            {
                DeactivateAllLights();
                colors[currentLightIndex].SetActive(true);
            }
        }
    }

    void DeactivateAllLights()
    {
        foreach (GameObject g in colors)
        {
            g.SetActive(false);
        }
    }

    public void ActivateRepeating(float t)
    {
        InvokeRepeating(nameof(ActivateNextLight), 0, t);

    }
}
