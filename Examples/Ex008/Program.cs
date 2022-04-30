//программа заполняет массив через генератор случайных чисел и ищет позицию
//числа 4. При отсутствии числа 4 выдает значение "-1"
void FillArray(int[] collection)
{
	int lenght = collection.Length;
	int index = 0;
	while (index < lenght)
	{
		collection[index] = new Random().Next(1,10);
		//index = index +1;
		index++;		
	}
}

void PrintArray(int[] col)
{
	int count = col.Length;
	int position = 0;
	while (position < count)
	{
		Console.WriteLine(col[position]);
		position++;
	}
}

int IndexOf(int[] collection, int find)
{
	int count = collection.Length;
	int index = 0;
	int position = -1; // если программа возвратит "-1" значит этого числа нет в массиве
	while (index < count)
	{
		if(collection[index] == find)
		{
			position = index;
            break;
		}	
		index++;
	}
	return position;
}


// void метод в C# который ничего не возвращает
int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);