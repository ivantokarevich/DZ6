// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


/* int[] Read()
{
	Console.WriteLine("Введите колличество элементов в массиве: ");
	int M = Convert.ToInt32(Console.ReadLine());
	int[] array = new int[M];
	for (int i = 0; i < M; i++)
	{
		Console.WriteLine("Введите " + (i + 1) + "й элемент массива: ");
		array[i] = Convert.ToInt32(Console.ReadLine());
	}
	return array;

}

int Calck(int[] array){
	int count = 0;
	for (int i = 0; i < array.Length; i++){
		if(array[i] > 0) count++;
	}
	return count;
}

void Print(int count){
	Console.WriteLine("Колличество элементов в массиве больше 0: " + count);
}

Print(Calck(Read())); */






// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double k1, b1, k2, b2;
Read();
if(k1 == k2) Console.WriteLine("Пересечения нет");
else Print(Point());


void Read()
{
	Console.WriteLine("Введите переменную k1: ");
	k1 = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Введите переменную b1: ");
	b1 = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Введите переменную k2: ");
	k2 = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Введите переменную b2: ");
	b2 = Convert.ToDouble(Console.ReadLine());
}


double[] Point(){
	double[] point = new double[2];
	double x, y;
	x = (b2-b1)/(k1-k2);
	y = k1 * x + b1;
	point[0] = x;
	point[1] = y;
	return point;

}

void Print(double[] point){
	Console.WriteLine("Точка пересечения (" + Math.Round(point[0], 3) + " ; " + Math.Round(point[1], 3) + ")");
}

