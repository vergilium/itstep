using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace HW_CS_8_Collections
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Dctionary Task 1
			language lang = language.RU_EN;
			String word, translate = null;

			Console.WriteLine("Hello, I`m Dictionary! Please enter need language. 1 - to Russian or any key to English");
			lang = (Console.ReadKey().Key == ConsoleKey.D1) ? language.EN_RU : language.RU_EN;
			Dictionary dic = new Dictionary(lang);
			Console.WriteLine($"OK. You need translate to {((lang == language.RU_EN) ? "English" : "Russian")} language");
			while (true) {
				Console.WriteLine("Please enter word... Or enter 'exit' to ");
				word = Console.ReadLine();
				translate = dic?.TranslateWord(word);
				if (translate != null) {
					Console.WriteLine($"{word} - {translate}");
				} else {
					Console.WriteLine($"Word {word} is not exist. Do you need insert this word in Dictionary? [Y/n]");
					switch (Console.ReadLine().ToUpper()) {
						case "Y":
						case "":
							Console.WriteLine($"For word: '{word}' enter translate.");
							translate = Console.ReadLine();
							dic.AddWord(word, translate);
							break;
						case "N": continue;
						default:
							Console.WriteLine("Incorrect answer!");
							break;
					}
				}
			}
			#endregion

		}
	}
}
