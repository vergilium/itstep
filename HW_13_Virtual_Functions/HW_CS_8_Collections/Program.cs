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
				Console.WriteLine("Please enter word... Or enter 'exit' to Exit");
				word = Console.ReadLine();
				if (word.ToUpper() == "EXIT") goto task2;
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
						case "EXIT": goto task2;
						default:
							Console.WriteLine("Incorrect answer!");
							break;
					}
				}
			}
		#endregion
			#region Point3D Task 2
			task2:;
			Point3D p3d = new Point3D();
			Point3D point3D = new Point3D(10, 20, 30);
			Console.WriteLine(p3d.ToString());
			Console.WriteLine(point3D.ToString());

			#endregion
			#region Line Task 3
			Line2D<int> line1 = new Line2D<int>(p3d, point3D);
			Line2D<double> line2 = new Line2D<double>(0.1, 0.5, 1.5, 2.5);
			Console.WriteLine($"Line 1: {line1.ToString()}");
			Console.WriteLine($"Line 2: {line2.ToString()}");

			#endregion
			#region Parser Task 4
			using (Parser prs = new Parser(@"HW.txt")) {
				prs.ParsText();
				Console.WriteLine(prs.ToString());
			}
			#endregion
		}
	}
}
