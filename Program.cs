#include <iostream>

using namespace std;

int main() {
    int num1, num2;
    char operation;

    cout << "Enter the first number: ";
    cin >> num1;

    cout << "Enter the second number: ";
    cin >> num2;

    cout << "Enter the operator (+, -, /, *): ";
    cin >> operation;

    if (operation == '+') {
        cout << num1 << " + " << num2 << " = " << num1 + num2 << endl;
    }
    else if (operation == '-') {
        cout << num1 << " - " << num2 << " = " << num1 - num2 << endl;
    }
    else if (operation == '*') {
        cout << num1 << " * " << num2 << " = " << num1 * num2 << endl;
    }
    else if (operation == '/') {
        if (num2 != 0) {
            cout << num1 << " / " << num2 << " = " << static_cast<double>(num1) / num2 << endl;
        }
        else {
            cout << "Error: Division by zero is not allowed." << endl;
        }
    }
    else {
        cout << "Error: Unsupported operator." << endl;
    }

    return 0;
}
