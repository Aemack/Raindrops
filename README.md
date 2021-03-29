# Raindrops

### User Guide
- Clone the repository and open it in Visual Studio
- Run the program to see a demo where you can select which numbers corrolate to what word
- Run the tests in the test explorer 

### Specifications
Write a function that takes as its input a number (n) and converts it to a string, the contents of which depend on the number's factors

- If the number has a factor of 3, output 'Pling'
- If the number has a factor of 5, output 'Plang'
- If the number has a factor of 7, output 'Plong'
- If the number does not have any of the above as a factor, simply return the number's digits.

##### Examples
- 28's factors are 1, 2, 4, 7, 14 and 28: this would be a simple 'Plong'
- 30's factors are 1, 2, 3, 5, 6, 10, 15, 30: this would be a 'PlingPlang'
- 34's factors are 1, 2, 17, and 34: this would be '34'

### Documentation

Created in C#, this program contains one class with a single contained method. 
- The class has three parameters which represent which numbers will be used for Pling, Plang and Plong
- The method takes in an integer and returns the correct string 

#### Tests

The tests were created using NUnit and are contained in two classes.
 - The first ensures that the method works with default values
 - The second ensures the method wprks with custom values
