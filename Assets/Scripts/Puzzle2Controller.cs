using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2Controller : MonoBehaviour
{
    [SerializeField] private int iTotalRuneValue, iRequiredRuneValue;
    [SerializeField] private GameObject Pillars;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void IncreaseVal(int iVal)
    {
        iTotalRuneValue += iVal;
    }

    // Update is called once per frame
    void Update()
    {
        if (iTotalRuneValue == iRequiredRuneValue)
        {
            Destroy(Pillars);
        }
    }
}
