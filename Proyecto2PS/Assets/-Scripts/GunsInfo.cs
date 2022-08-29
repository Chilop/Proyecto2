using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun info", menuName = "Mutation data")]

public class GunsInfo : ScriptableObject
{
    // las armas son las mutaciones, pero se tratan como armas

    // atributos que tiene cada arma

    [SerializeField] private string mutationName;
    public string description;
    public int damage;

    public string MutationName => mutationName;
    public string Description;
    public int Damage;
}
