using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1Controller : MonoBehaviour
{
    public bool bRune1Lit, bRune2Lit, bRune3Lit, bRune4Lit, bRune5Lit, bRune6Lit, bRune7Lit, bRune8Lit, bRune9Lit;
    public bool bRune12Lit, bRune22Lit, bRune32Lit, bRune42Lit, bRune52Lit, bRune62Lit, bRune72Lit, bRune82Lit, bRune92Lit;
    public bool bRune1PLit, bRune2PLit, bRune3PLit, bRune4PLit, bRune5PLit, bRune6PLit, bRune7PLit, bRune8PLit, bRune9PLit;
    [SerializeField] private GameObject rune1, rune2, rune3, rune4, rune5, rune6, rune7, rune8, rune9, rune12, rune22, rune32, rune42, rune52, rune62, rune72, rune82, rune92;
    private bool doorOpen;
    [SerializeField] private GameObject Door1, Door2;
    Material m_Material;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void DimRune(int runeNumber)
    {
        switch (runeNumber)
        {
            case 1:
                if (bRune1PLit == false)
                {
                    bRune1Lit = false;
                }
                break;
            case 2:
                if (bRune2PLit == false)
                {
                    bRune2Lit = false;
                }
                break;
            case 3:
                if (bRune3PLit == false)
                {
                    bRune3Lit = false;
                }
                break;
            case 4:
                if (bRune4PLit == false)
                {
                    bRune4Lit = false;
                }
                break;
            case 5:
                if (bRune5PLit == false)
                {
                    bRune5Lit = false;
                }
                break;
            case 6:
                if (bRune6PLit == false)
                {
                    bRune6Lit = false;
                }
                break;
            case 7:
                if (bRune7PLit == false)
                {
                    bRune7Lit = false;
                }
                break;
            case 8:
                if (bRune8PLit == false)
                {
                    bRune8Lit = false;
                }
                break;
            case 9:
                if (bRune9PLit == false)
                {
                    bRune9Lit = false;
                }
                break;
            case 12:
                if (bRune1PLit == false)
                {
                    bRune12Lit = false;
                }
                break;
            case 22:
                if (bRune2PLit == false)
                {
                    bRune22Lit = false;
                }
                break;
            case 32:
                if (bRune3PLit == false)
                {
                    bRune32Lit = false;
                }
                break;
            case 42:
                if (bRune4PLit == false)
                {
                    bRune42Lit = false;
                }
                break;
            case 52:
                if (bRune5PLit == false)
                {
                    bRune52Lit = false;
                }
                break;
            case 62:
                if (bRune6PLit == false)
                {
                    bRune62Lit = false;
                }
                break;
            case 72:
                if (bRune7PLit == false)
                {
                    bRune72Lit = false;
                }
                break;
            case 82:
                if (bRune8PLit == false)
                {
                    bRune82Lit = false;
                }
                break;
            case 92:
                if (bRune9PLit == false)
                {
                    bRune92Lit = false;
                }
                break;
        }
    }

    public void LightRune(int runeNumber)
    {
        switch (runeNumber)
        {
            case 1:
                bRune1Lit = true;
                break;
            case 2:
                bRune2Lit = true;
                break;
            case 3:
                bRune3Lit = true;
                break;
            case 4:
                bRune4Lit = true;
                break;
            case 5:
                bRune5Lit = true;
                break;
            case 6:
                bRune6Lit = true;
                break;
            case 7:
                bRune7Lit = true;
                break;
            case 8:
                bRune8Lit = true;
                break;
            case 9:
                bRune9Lit = true;
                break;
            case 12:
                bRune12Lit = true;
                break;
            case 22:
                bRune22Lit = true;
                break;
            case 32:
                bRune32Lit = true;
                break;
            case 42:
                bRune42Lit = true;
                break;
            case 52:
                bRune52Lit = true;
                break;
            case 62:
                bRune62Lit = true;
                break;
            case 72:
                bRune72Lit = true;
                break;
            case 82:
                bRune82Lit = true;
                break;
            case 92:
                bRune92Lit = true;
                break;
        }
    }

    private void PermaLit()
    {
        if (bRune1Lit)
        {
            m_Material = rune1.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune1.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune2Lit)
        {
            m_Material = rune2.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune2.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune3Lit)
        {
            m_Material = rune3.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune3.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune4Lit)
        {
            m_Material = rune4.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune4.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune5Lit)
        {
            m_Material = rune5.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune5.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune6Lit)
        {
            m_Material = rune6.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune6.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune7Lit)
        {
            m_Material = rune7.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune7.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune8Lit)
        {
            m_Material = rune8.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune8.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune9Lit)
        {
            m_Material = rune9.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune9.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune12Lit)
        {
            m_Material = rune12.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune12.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune22Lit)
        {
            m_Material = rune22.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune22.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune32Lit)
        {
            m_Material = rune32.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune32.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune42Lit)
        {
            m_Material = rune42.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune42.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune52Lit)
        {
            m_Material = rune52.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune52.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune62Lit)
        {
            m_Material = rune62.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune62.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune72Lit)
        {
            m_Material = rune72.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune72.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune82Lit)
        {
            m_Material = rune82.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune82.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
        if (bRune92Lit)
        {
            m_Material = rune92.GetComponent<Renderer>().material;
            m_Material.color = Color.white;
        }
        else
        {
            m_Material = rune92.GetComponent<Renderer>().material;
            m_Material.color = Color.grey;
        }
    }

    // Update is called once per frame
    void Update()
    {
        PermaLit();
        if (bRune1Lit && bRune12Lit)
        {
            bRune1PLit = true;
        }
        if (bRune2Lit && bRune22Lit)
        {
            bRune2PLit = true;
        }
        if (bRune3Lit && bRune32Lit)
        {
            bRune3PLit = true;
        }
        if (bRune4Lit && bRune42Lit)
        {
            bRune4PLit = true;
        }
        if (bRune5Lit && bRune52Lit)
        {
            bRune5PLit = true;
        }
        if (bRune6Lit && bRune62Lit)
        {
            bRune6PLit = true;
        }
        if (bRune7Lit && bRune72Lit)
        {
            bRune7PLit = true;
        }
        if (bRune8Lit && bRune82Lit)
        {
            bRune8PLit = true;
        }
        if (bRune9Lit && bRune92Lit)
        {
            bRune9PLit = true;
        }
        
        if (bRune1PLit && bRune2PLit && bRune3PLit && bRune4PLit && bRune5PLit && bRune6PLit && bRune7PLit && bRune8PLit && bRune9PLit && doorOpen == false)
        {
            Debug.Log("Door opened!");
            Destroy(Door1);
            Destroy(Door2);
            doorOpen = true;
        }
    }
}
