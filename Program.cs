/*
static void Main(string[])
{

    int[] sizes = {10, 100, 1000, 10000, 100000};
    Random random = new Random();
    Console.WriteLine("tid");
}
*/

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