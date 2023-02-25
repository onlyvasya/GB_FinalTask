string[] array1 = new string[5] {"hi", "qwewrty", "hello", "world", "res"};
int count = 0;
for (int i = 0; i < array1.Length; i++)
{
    if(array1[i].Length<=3) count++;
}
string[] array2 = new string[count];
int k=0;
for (int j = 0; j < array1.Length; j++)
{
    if(array1[j].Length<=3) 
    {
        array2[k]=array1[j];
        k++;
    }
}    
for (int c = 0; c < array2.Length; c++)
{
    System.Console.Write(array2[c]+" ");
}