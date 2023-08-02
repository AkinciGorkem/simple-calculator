# Simple Calculator

This repository contains a simple calculator application written in C#. The calculator supports basic arithmetic operations such as addition, subtraction, multiplication, and division.

## Prerequisites

Make sure you have installed:

- .NET Framework (version 4.7.2 or later)

## Installation

1. Clone the repository:

   ```
   git clone https://github.com/<AkinciGorkem>/simple-calculator.git
   ```

2. Open the solution in Visual Studio and build it by pressing `Ctrl+Shift+B` or by choosing `Build -> Build Solution` from the menu.

## Usage

The calculator provides a straightforward interface for performing arithmetic operations:

- Enter numbers by clicking the appropriate number buttons in the user interface.
- Choose the operation to be performed (addition, subtraction, multiplication, division) by clicking the corresponding button.
- After selecting the operation, enter the second operand.
- Click the equals (=) button to perform the calculation.
- The result will be displayed in the text box.
- If you want to perform an operation on the result, just click the next operation. If you want to start a new calculation, press the 'C' button to clear the input and results.

## Code Overview

The calculator's functionality is implemented in `Form1.cs`. The key functions are:

- `AddNumber(object sender, EventArgs e)` : This function is responsible for appending the digit clicked by the user to the textbox.
- `Operations(object sender, EventArgs e)` : This function is triggered when an operator button is clicked. It stores the current number in `accumulatedValue` and saves the operation to be performed.
- `Calculate(object sender, EventArgs e)` : This function is triggered when the equals button is clicked. It performs the operation stored by the `Operations` function on `accumulatedValue` and the number in the textbox.
- `PerformOperation(double operand)` : This function performs the operation specified by the `operation` variable on `accumulatedValue` and `operand`.
- `Clear(object sender, EventArgs e)` : This function clears the textbox, the `accumulatedValue`, and the `operation`.
- `textBox1_KeyPress(object sender, KeyPressEventArgs e)` : This function validates the keypresses in the textbox to ensure only valid numbers are entered.

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License

[MIT](https://choosealicense.com/licenses/mit/)
