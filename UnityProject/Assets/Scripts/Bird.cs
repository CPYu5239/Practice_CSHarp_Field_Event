using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("移動速度")]
    [Range(1f,100f)]
    public float Speed;

    [Header("跳躍高度")]
    [Range(1f, 100f)]
    public float Jump;

    [Header("對話內容")]
    public string Talk = "咕咕咕咕~~";

    [Header("是否獲得雞蛋")]
    public bool Egg;

    void Start()
    {
        print("遊戲開始!!!");   
    }

    
    void Update()
    {
        print(Talk);
    }
}
