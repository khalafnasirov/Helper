namespace Helper
{
	public static class Cons
	{
		public static void Print()
		{
			Console.WriteLine();
		}

		public static void Print(object obj)
		{
			string? msg = obj.ToString();

			Console.WriteLine(msg);
		}

		public static void SeperateLine(int length)
		{
			for (int i = 0; i < length; i++)
			{
				Console.Write("-");
			}
			Console.WriteLine();
		}
	}

	public static class ListOps
	{
		public static void ShowElements <T> (IEnumerable<T> list)
		{
			if (list.Count() > 0)
			{
				foreach (var item in list)
				{
					Console.WriteLine(item);
				}
			}
		}

		public static void ShowElements <T> (ICollection<T> list)
		{
			if (list.Count() > 0)
			{
				foreach (var item in list)
				{
					Console.WriteLine(item);
				}
			}
		}
	}

	public static class StringOps
	{
		public static string Combine(object ob1,  object ob2)
		{
			return ob1?.ToString() + ob2?.ToString();
		}

        public static string Combine(object ob1, object ob2, object ob3)
        {
			return ob1?.ToString() + ob2?.ToString() + ob3?.ToString();
        }

        public static string Combine(object ob1, object ob2, object ob3, object ob4)
        {
            return ob1?.ToString() + ob2?.ToString() + ob3?.ToString() + ob4?.ToString();
        }

        public static string Combine(object ob1, object ob2, object ob3, object ob4, object ob5)
        {
			return ob1?.ToString() + ob2?.ToString() + ob3?.ToString() + ob4?.ToString() + ob5?.ToString();
        }

		public static string Combine(params object[] args)
		{
			string? full = string.Empty;

			for (int i = 0; i < args.Length; i++)
			{
				full += args[i].ToString();
			}

			return full;
		}
    }
}