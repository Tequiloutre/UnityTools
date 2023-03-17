using UnityEngine;

public class TestClass : MonoBehaviour
{
	[SerializeField] private bool condition = false;
	[SerializeField, EditCondition("condition")] private int value = 0;

	public bool Condition => condition;
	public int Value => value;
}
