using System;
using UnityEngine;

[Serializable]
public struct SKeyValuePair<TKey, TValue>
{
	[SerializeField] private TKey key;
	[SerializeField] private TValue value;

	public TKey Key => key;
	public TValue Value => value;

	public SKeyValuePair(TKey _key, TValue _value)
	{
		key = _key;
		value = _value;
	}
	
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
	public void Deconstruct(out TKey _key, out TValue _value)
	{
		_key = key;
		_value = value;
	}
	public override string ToString() => $"[{key}, {value}]";
}
