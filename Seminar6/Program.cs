// Ex1 разворот массива
int[] ReverseArray(int[]array)
{
    int temp; 
    int j = array.Length -1;
    for(int i = 0; i < (array.Length)/2; i++, j--)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
        
    }

    //while (i<j) вместо цикла фор, исп цикл while;
  //  {
 //        temp = array[i];
  //      array[i] = array[j];
   //     array[j] = temp;
   //     i++;
  //      j--; 
    //}
    return array;
}

int[] MyArray= {1, 2, 3, 4, 5, 6, 7};
MyArray = ReverseArray(MyArray);
for(int i=0; i <MyArray.Length; i++)
{
    Console.Write(MyArray[i] + " ");
}