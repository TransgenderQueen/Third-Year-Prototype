

ChatGPT example
'
#include <iostream>
#include <vector>
#include <string>
#include <functional>

class Item {
public:
    std::string name;
    int value;
    double weight;

    Item(const std::string& n, int v, double w) : name(n), value(v), weight(w) {}

    // For printing the item
    friend std::ostream& operator<<(std::ostream& os, const Item& item) {
        os << "Item(Name: " << item.name << ", Value: " << item.value << ", Weight: " << item.weight << ")";
        return os;
    }
};

template <typename T>
void bubbleSort(std::vector<T>& arr, std::function<bool(const T&, const T&)> compare) {
    size_t n = arr.size();
    for (size_t i = 0; i < n - 1; ++i) {
        for (size_t j = 0; j < n - i - 1; ++j) {
            if (compare(arr[j], arr[j + 1])) {
                // Swap arr[j] and arr[j + 1]
                std::swap(arr[j], arr[j + 1]);
            }
        }
    }
}

template <typename T>
void printArray(const std::vector<T>& arr) {
    for (const T& elem : arr) {
        std::cout << elem << std::endl;
    }
}

// Comparison functions
bool compareByValue(const Item& a, const Item& b) {
    return a.value > b.value; // Sort by value in descending order
}

bool compareByWeight(const Item& a, const Item& b) {
    return a.weight > b.weight; // Sort by weight in descending order
}

int main() {
    std::vector<Item> items = {
        Item("Item1", 64, 10.5),
        Item("Item2", 34, 5.2),
        Item("Item3", 25, 7.4),
        Item("Item4", 12, 3.3),
        Item("Item5", 22, 4.8),
        Item("Item6", 11, 8.9),
        Item("Item7", 90, 1.5)
    };

    std::cout << "Original array:\n";
    printArray(items);

    // Sort by value
    bubbleSort(items, compareByValue);
    std::cout << "\nSorted by value (descending):\n";
    printArray(items);

    // Sort by weight
    bubbleSort(items, compareByWeight);
    std::cout << "\nSorted by weight (descending):\n";
    printArray(items);

    return 0;
}
'

