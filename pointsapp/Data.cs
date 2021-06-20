using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pointsapp
{
	class UserData
	{
		public static string paths = @"C:\Data\users.txt";
		public static void reset(string phonenumber)
		{
			List<string> lines = File.ReadAllLines(paths).ToList();
			int i = 1;
			foreach (var line in lines)
			{
				if (line == phonenumber)
				{
					string points = lines[i];
					lines[i] = "0";
					File.WriteAllLines(paths, lines);
				}
				i++;
			}
		}
		public static int CheckUser(string phonenumber)
		{
			List<string> lines = File.ReadAllLines(paths).ToList();
			int i = 1;
			foreach (var line in lines)
			{
				if (line == phonenumber)
				{
					string points = lines[i];
					return int.Parse(points);
				}
				i++;
			}
			return 0;
		}
		public static void AddUser(string name, string phonenumber)
		{
			List<string> lines = File.ReadAllLines(paths).ToList();
			lines.Add(name);
			lines.Add(phonenumber);
			lines.Add("0");
			File.WriteAllLines(paths, lines);
		}
		public static void AddPoints(string phonenumber, string pointstoadd)
		{
			List<string> lines = File.ReadAllLines(paths).ToList();
			int i = 1;
			foreach (var line in lines)
			{
				if (line == phonenumber)
				{
					int intpoints = int.Parse(lines[i]);
					int newtotal = intpoints + int.Parse(pointstoadd);
					lines[i] = newtotal.ToString();

					File.WriteAllLines(paths, lines);
					break;
				}
				i++;
			}
		}
		
	}
}
