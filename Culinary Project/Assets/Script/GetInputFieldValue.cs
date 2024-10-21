using UnityEngine;
using TMPro;
public class GetInputFieldValue : MonoBehaviour
{
    [SerializeField]
    TMP_InputField amt1;
    [SerializeField]
    TMP_InputField cost1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float cost = -1;
            Debug.Log(float.TryParse(cost1.text, out cost));
            float flourAmt = -1;
            Debug.Log(float.TryParse(amt1.text, out flourAmt));
            Debug.Log(flourAmt * cost);
        }
    }
}
