using UnityEngine;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{
    [SerializeField] private SpawnManager spawnManager;
    [SerializeField] private Button spawnButton;
    [SerializeField] private Text middleText;
    void Awake()
    {
        middleText.text = "Hello " + MenuManager.Instance.playerName;
    }
    void Start()
    {
        spawnButton.onClick.AddListener(spawnManager.SpawnCar);
    }
}
