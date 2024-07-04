
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SwitchNumber : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Button resetButton;
    [SerializeField] private Button switchButton;

    private int[] arr = new int[10];
    private void Awake()
    {
        resetButton.onClick.AddListener(() => InitArr());
        switchButton.onClick.AddListener(() => RandomSwitch());
        InitArr();
    }

    private void InitArr()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }
        Print();
    }

    private void RandomSwitch()
    {
        int randomIndex = Random.Range(0, arr.Length);
        int randomIndex2 = Random.Range(0, arr.Length);

        int temp = arr[randomIndex];
        arr[randomIndex] = arr[randomIndex2];
        arr[randomIndex2] = temp;
        Print();
    }

    private void Print()
    {
        string result = "";
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 0) result = arr[i].ToString();
            else result = $"{result} {arr[i]}";
        }

        text.text = result;
    }
}
