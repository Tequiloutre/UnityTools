using UnityEngine;

public class TestClass : MonoBehaviour
{
	[SerializeField] private bool condition = false;
	[SerializeField, EditCondition("condition")] private int value = 0;
	[SerializeField] private SDictionary<string, int> dico = new SDictionary<string, int>();

	public bool Condition => condition;
	public int Value => value;
	public SDictionary<string, int> Dico => dico;
}
