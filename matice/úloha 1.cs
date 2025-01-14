int[,] matice = new int[2, 3];

int radku = matice.GetLength(0);
int sloupcu = matice.GetLength(1);
int cleny = radku * sloupcu;

for (int i = 0; i < radku; i++)
	{
	for (int j = 0; j < sloupcu; j++)
		{
			Console.WriteLine("Jednu hodnotu rosím!");
			int hodnota = Convert.ToInt32(Console.ReadLine());
			matice[i, j] = hodnota;
		}
	}

for (int i = 0; i < radku; i++)
	{
	for (int j = 0; j < sloupcu; j++)
		{
			Console.Write(matice[i, j] + " ");
		}
	Console.WriteLine();
	}