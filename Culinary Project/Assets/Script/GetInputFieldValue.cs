using UnityEngine;
using TMPro;
public class GetInputFieldValue : MonoBehaviour
{
    [SerializeField]
    TMP_InputField amt1;
    [SerializeField]
    TMP_InputField cost1;
    [SerializeField]
    TMP_InputField amt2;
    [SerializeField]
    TMP_InputField cost2;
    [SerializeField]
    TMP_InputField amt3;
    [SerializeField]
    TMP_InputField cost3;
    [SerializeField]
    TMP_InputField amt4;
    [SerializeField]
    TMP_InputField cost4;
    [SerializeField]
    TMP_InputField amt5;
    [SerializeField]
    TMP_InputField cost5;
    [SerializeField]
    TMP_InputField amt6;
    [SerializeField]
    TMP_InputField cost6;
    [SerializeField]
    TMP_InputField amt7;
    [SerializeField]
    TMP_InputField cost7;
    [SerializeField]
    TMP_InputField markupBox;
    [SerializeField]
    TMP_InputField unitsSold;
    [SerializeField]
    TMP_Text calculatedNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Calculate()
    {
        // Get raw cost of item 1
        float cost = -1;
        Debug.Log(float.TryParse(cost1.text, out cost));
        float item1Amt = -1;
        Debug.Log(float.TryParse(amt1.text, out item1Amt));
        Debug.Log(item1Amt * cost);
        //get raw cost of item 2
        float item2Cost = -1;
        Debug.Log(float.TryParse(cost2.text, out item2Cost));
        float item2Amt = -1;
        Debug.Log(float.TryParse(amt2.text, out item2Amt));
        Debug.Log(item2Amt * item2Cost);
        //Get raw cost of item 3
        float item3Cost = -1;
        Debug.Log(float.TryParse(cost3.text, out item3Cost));
        float item3Amt = -1;
        Debug.Log(float.TryParse(amt3.text, out item3Amt));
        Debug.Log(item3Amt * item3Cost);
        // cost of item 4
        float item4Cost = -1;
        Debug.Log(float.TryParse(cost4.text, out item4Cost));
        float item4Amt = -1;
        Debug.Log(float.TryParse(amt4.text, out item4Amt));
        Debug.Log(item4Amt * item4Cost);
        // cost of item 5
        float item5Cost = -1;
        Debug.Log(float.TryParse(cost5.text, out item5Cost));
        float item5Amt = -1;
        Debug.Log(float.TryParse(amt5.text, out item5Amt));
        Debug.Log(item5Amt * item5Cost);
        // item 6
        float item6Cost = -1;
        Debug.Log(float.TryParse(cost6.text, out item6Cost));
        float item6Amt = -1;
        Debug.Log(float.TryParse(amt6.text, out item6Amt));
        Debug.Log(item6Amt * item6Cost);
        // item 7
        float item7Cost = -1;
        Debug.Log(float.TryParse(cost7.text, out item7Cost));
        float item7Amt = -1;
        Debug.Log(float.TryParse(amt7.text, out item7Amt));
        Debug.Log(item7Amt * item7Cost);
        // add all of the costs
        float totalCost = (item1Amt * cost) + (item2Amt * item2Cost) + (item3Amt * item3Cost) + (item4Amt * item4Cost) + (item5Amt * item5Cost) + (item6Amt * item6Cost) + (item7Amt * item7Cost);
        Debug.Log(totalCost);
        // get markup
        float markup = -1;
        Debug.Log(float.TryParse(markupBox.text, out markup));
        //get markup value
        float markupValue = markup * totalCost;
        Debug.Log(markupValue);
        // find cost per unit
        float units = -1;
        Debug.Log(float.TryParse(unitsSold.text, out units));
        float cpu = markupValue / units;
        //make cpu show up on screen
        calculatedNumber.text = cpu.ToString();
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Clear()
    {
        amt1.text = 0.ToString();
        amt2.text = 0.ToString();
        amt3.text = 0.ToString();
        amt4.text = 0.ToString();
        amt5.text = 0.ToString();
        amt6.text = 0.ToString();
        amt7.text = 0.ToString();
        cost1.text = 0.ToString();
        cost2.text = 0.ToString();
        cost3.text = 0.ToString();
        cost4.text = 0.ToString();
        cost5.text = 0.ToString();
        cost6.text = 0.ToString();
        cost7.text = 0.ToString();
        markupBox.text = 0.ToString();
        unitsSold.text = 0.ToString();
        calculatedNumber.text = 0.ToString();
    }
}
