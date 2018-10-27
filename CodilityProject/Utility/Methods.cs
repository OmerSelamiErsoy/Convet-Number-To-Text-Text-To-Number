﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProject.Utility
{
	static class Methods
	{
		internal static  string ToReplaceTurkishCharacter(this string text)
		{
			text = text.Replace("İ", "I");
			text = text.Replace("ı", "i");
			text = text.Replace("Ğ", "G");
			text = text.Replace("ğ", "g");
			text = text.Replace("Ö", "O");
			text = text.Replace("ö", "o");
			text = text.Replace("Ü", "U");
			text = text.Replace("ü", "u");
			text = text.Replace("Ş", "S");
			text = text.Replace("ş", "s");
			text = text.Replace("Ç", "C");
			text = text.Replace("ç", "c");
			text = text.Replace(" ", "_");
			return text;
		}
	}
}
