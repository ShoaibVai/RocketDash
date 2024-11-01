#include<iostream>
#include<algorithm>
using namespace std;

int main(int argc, char const *argv[])
{
    const int SIZE = 3; // Define the size of the array
    int arr[SIZE];

    // Input elements into the array
    for (int i = 0; i < SIZE; i++)
    {
        cin >> arr[i];
    }

    // Sort the array
    sort(arr,arr+SIZE);

    // Output the sorted array
    for (int i = 0; i < SIZE; i++)
    {
        cout << arr[i] << " ";
    }
    cout << endl;

    return 0;
}
