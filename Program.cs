/*
static void Main(string[])
{

    int[] sizes = {10, 100, 1000, 10000, 100000};
    Random random = new Random();
    Console.WriteLine("tid");
}
*/

/*
using System.Numerics;

void bubbleSort(Vector<int>& arr) {
    int n =  arr.size();
    bool swapped;

    for(int i = 0; i < n - 1; i++){
        swapped = false;
        for (int j = 0; j < n - 1; j++){
            if(arr[j] > arr[j + 1]) {
                swap(arr[j], arr[j + 1]);
                swapped = true;
            }
        }


        if (!swapped)
            break;
    }
}

void printVector(const Vector<int>& arr) {
    for (int num : arr)
        cout << "" << num;
}

int Main()
*/

static void bubbleSort ( int [] arr, int n){
    int i, j, temp;
    bool swapped;
    for (i=0; i< n - 1; i++){
        swapped= false;
        for (j=0; j< n - i - 1; j++){
            if(arr[j]> arr[j + 1]){

                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
                swapped = true;
            }
        }
        if (swapped == false)
            break;
    }
}

 static void printArray(int[] arr, int size){
        int i;
        for (i = 0; i < size; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

  public static void Main(){
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        int n = arr.Length;
        bubbleSort(arr, n);
        Console.WriteLine("Sorted array:");
        printArray(arr, n);
    }
