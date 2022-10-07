using UnityEngine;
[CreateAssetMenu(fileName = "New Gun info", menuName = "Mutation data")]
public class GunsInfo : ScriptableObject
{
    [SerializeField] private string mutationName = default;
    [SerializeField] private string description = default;
    [SerializeField] private int damage = default;
    [SerializeField] private GameObject weapon = default;
    public string MutationName => mutationName;
    public string Description => description;
    public int Damage => damage;
    public GameObject Weapon => weapon;
}
