
using UnityEngine;

public class StringSum : MonoBehaviour
{
    private string myText = "안녕하세요";
    private string extraString = "Extra";
    private void Awake()
    {
        Sum(myText);
    }

    private void Sum(string targetString)
    {
        string result = $"{myText}{extraString}";
        Debug.Log(result);
    }
}
