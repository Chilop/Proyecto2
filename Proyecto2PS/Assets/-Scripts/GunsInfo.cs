using UnityEngine;
[CreateAssetMenu(fileName = "New Gun info", menuName = "Mutation data")]
public class GunsInfo : ScriptableObject
{
    [SerializeField] private string mutationName;
    [SerializeField] private string description;
    [SerializeField] private int damage;
    public string MutationName => mutationName;
    public string Description => description;
    public int Damage => damage;
}
