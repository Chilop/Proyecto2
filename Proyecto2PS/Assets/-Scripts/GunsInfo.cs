using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun info", menuName = "Mutation data")]

public class GunsInfo : ScriptableObject
{
    // las armas son las mutaciones, pero se tratan como armas

    // atributos que tiene cada arma

    // es para ponerlo privado y que se pueda ver desde el inspector
    [SerializeField] private string mutationName;
    //public string mutationName;
    public string description;
    public int damage;

   // se define para que ponga la informacion para los campos privados
    public string MutationName => mutationName;

    public GameObject PrefabGun { get; internal set; }
    //public string Description;
    //public int Damage;

}
