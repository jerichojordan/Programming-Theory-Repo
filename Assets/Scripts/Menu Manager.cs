using UnityEngine;
public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance { get; private set; }
    public string playerName;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(Instance);
    }
}
