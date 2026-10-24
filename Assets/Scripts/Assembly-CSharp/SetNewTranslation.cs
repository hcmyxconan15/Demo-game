using System.Collections.Generic;
using UnityEngine;

public class SetNewTranslation : MonoBehaviour
{
	[TextArea(4, 20)]
	public string TextData;

	[Header("Data")]
	public int ElementsCount;

	public bool IsWrong;

	public int WrongLine;

	public int HeroIndex;

	public List<DataParseText> DataParseText;

	public InternationalizationDb InternationalizationDb;

	public void ClearData()
	{
	}

	public void SetData()
	{
	}
}
