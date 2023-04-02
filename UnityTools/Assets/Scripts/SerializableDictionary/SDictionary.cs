using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class SDictionary<TKey, TValue> : ICollection<SKeyValuePair<TKey, TValue>>
{
	[SerializeField] private List<SKeyValuePair<TKey, TValue>> content = new List<SKeyValuePair<TKey, TValue>>();

	public TValue this[TKey _key] => content.First(_pair => _pair.Key.Equals(_key)).Value;
	public SKeyValuePair<TKey, TValue> GetPair(TKey _key) => content.First(_pair => _pair.Key.Equals(_key));

	public int Count => content.Count;
	public bool IsReadOnly => false;
	public bool ContainsKey(TKey _key) => content.Any(_pair => _pair.Key.Equals(_key));
	public bool ContainsValue(TValue _value) => content.Any(_pair => _pair.Value.Equals(_value));
	public bool Contains(SKeyValuePair<TKey, TValue> _pair) => content.Contains(_pair);
	public void CopyTo(SKeyValuePair<TKey, TValue>[] _array, int _arrayIndex)
	{
		int _count = _array.Length;
		foreach (SKeyValuePair<TKey,TValue> _pair in content)
		{
			if (_arrayIndex >= _count) return;
			_array[_arrayIndex] = _pair;
			++_arrayIndex;
		}
	}
	public void Add(TKey _key, TValue _value)
	{
		if (ContainsKey(_key)) return;
		content.Add(new SKeyValuePair<TKey, TValue>(_key, _value));
	}
	public void Add(SKeyValuePair<TKey, TValue> _pair) => Add(_pair.Key, _pair.Value);
	public bool Remove(TKey _key) => ContainsKey(_key) && content.Remove(content.First(_pair => _pair.Key.Equals(_key)));
	public bool Remove(SKeyValuePair<TKey, TValue> _pair) => Contains(_pair) && content.Remove(_pair);
	public void Clear() => content.Clear();
	
	public IEnumerator<SKeyValuePair<TKey, TValue>> GetEnumerator() => content.GetEnumerator();
	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
