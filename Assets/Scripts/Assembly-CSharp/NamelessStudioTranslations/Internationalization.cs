using UnityEngine;

namespace NamelessStudioTranslations
{
	public class Internationalization : MonoBehaviour
	{
		public string TableName;

		public static Internationalization Instance;

		public void SetLangIndexAndUpdateScene(int index, bool setAsUserSelection = true)
		{
		}

		private void Awake()
		{
		}

		public string GetWord(string key)
		{
			return null;
		}

		public int ResolveLanguageIndex()
		{
			return 0;
		}

		private bool HasUserSelectedLanguage(out int languageIndex)
		{
			languageIndex = default;
			return false;
		}

		private bool IsLocaleIndexValid(int index)
		{
			return false;
		}

		private bool TryFindLocaleIndex(string languageCode, out int languageIndex)
		{
			languageIndex = default;
			return false;
		}

		private bool TryFindLocaleIndexByParent(string parentLanguageCode, out int languageIndex)
		{
			languageIndex = default;
			return false;
		}

		private int GetEnglishFallbackIndex()
		{
			return 0;
		}

		private string NormalizeLanguageCode(string languageCode)
		{
			return null;
		}

		private string GetParentLanguageCode(string languageCode)
		{
			return null;
		}

		private bool TryGetDeviceLanguageCode(out string languageCode)
		{
			languageCode = null;
			return false;
		}

		private bool TryGetSteamLanguageCode(out string languageCode)
		{
			languageCode = null;
			return false;
		}
	}
}
