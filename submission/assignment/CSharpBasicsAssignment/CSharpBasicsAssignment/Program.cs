/*
 * ==================== PROJECT & STRUCTURE ====================
 *
 * .csproj:
 * Contains the target framework (.NET 10?),
 * enables or disables features in your project,
 * and contains package versions.
 *
 * Program.cs:
 * The main C# source code and the file that starts the execution.
 *
 * obj/:
 * Contains intermediate files generated during the build process.
 *
 * bin/:
 * Contains the final output files generated after building the project
 * (.exe, .dll).
 *
 * --------------------------------------------------------------
 *
 * File-scoped namespace:
 * Applies to the entire file, so we don't need braces or an extra indentation level.
 * (namespace CSharpBasicsAssignment;)
 *
 * --------------------------------------------------------------
 *
 * My project uses the newer .slnx file format.
 * One advantage of the classic .sln format is that it has wider compatibility
 * with older tools and Visual Studio versions.
 */


using System.Collections.Specialized;


// ==================== PART A: PROJECT & STRUCTURE ====================

Console.WriteLine("=== PART A: Project & Structure ===");
RunPartA();

void RunPartA()
{
    Console.WriteLine("Project structure information is documented in the comments above.");
}


// ==================== PART B: VARIABLES, TYPES & CASTING ====================

Console.WriteLine("=== PART B: Variables, Types & Casting ===");
Console.WriteLine();
RunTypesDemo();

void RunTypesDemo()
{
    // ==================== 1- VARIABLES AND TYPES ====================

    int age = 24;
    long testNumber = 100000000;
    double price = 22.22;
    decimal salary = 232.532m;
    bool isTrue = true;
    char a = 'a';
    string student = " aya atea ";
    var city = "monofia ";

    Console.WriteLine("Experiment 1 - variables and types");
    Console.WriteLine($"age = {age}, Type = {age.GetType()}");
    Console.WriteLine($"testNumber = {testNumber}, Type = {testNumber.GetType()}");
    Console.WriteLine($"price = {price}, Type = {price.GetType()}");
    Console.WriteLine($"salary = {salary}, Type = {salary.GetType()}");
    Console.WriteLine($"isTrue = {isTrue}, Type = {isTrue.GetType()}");
    Console.WriteLine($"a = {a}, Type = {a.GetType()}");
    Console.WriteLine($"student = {student}, Type = {student.GetType()}");
    Console.WriteLine($"city = {city}, Type = {city.GetType()}");


    // ==================== 2- IMPLICIT CONVERSION ====================

    // long can represent all int values without lose in data
    int number = 83;
    long longNumber = number;

    Console.WriteLine();
    Console.WriteLine("Experiment 2 - IMPLICIT CONVERSION:");
    Console.WriteLine($"int to long : {longNumber}");

    // char can converted to integer unicode of letter
    char letter = 'b';
    int valueOfLetter = letter;

    Console.WriteLine($"char to int : {valueOfLetter}");


    // ==================== 3- EXPLICIT CONVERSION ====================

    double cost = 10.8;

    // casting using (int) truncates decimal part of number
    int integerCost = (int)cost;

    // while using convert > it will round number to nearest integer number
    int roundCost = Convert.ToInt32(cost);
    Console.WriteLine();
    Console.WriteLine("Experiment 3 - EXPLICIT CONVERSION:");
    Console.WriteLine($"(int) Result : {integerCost}");
    Console.WriteLine($"(convert Toint32) Result : {roundCost}");


    // ==================== INTEGER DIVISION TRAP ====================

    // When both are integers, integer division removes the decimal part;
    // using a double produces floating-point division.

    int result1 = 5 / 2;
    double result2 = 5.0 / 2;

    Console.WriteLine();
    Console.WriteLine("Experiment 4 - INTEGER DIVISION TRAP:");
    Console.WriteLine($"5 / 2 = {result1}");
    Console.WriteLine($"5.0 / 2 = {result2}");


    // ==================== 4- BOXING AND UNBOXING ====================

    int value = 42;

    object boxedValue = value;

    Console.WriteLine();
    Console.WriteLine("Experiment 5 - BOXING AND UNBOXING:");
    Console.WriteLine($"After boxing: {boxedValue}");

    int unboxedValue = (int)boxedValue;

    Console.WriteLine($"After unboxing: {unboxedValue}");


    // ==================== 5- PARSING ====================

    string validString = "42";
    int parsedValue = int.Parse(validString);

    Console.WriteLine();
    Console.WriteLine("Experiment 6 - PARSING:");
    Console.WriteLine($"int.Parse = {parsedValue}");


    // TryParse
    string abcString = "abc";

    bool success = int.TryParse(abcString, out int result);

    Console.WriteLine($"TryParse succeeded: {success}");

    if (!success)
    {
        Console.WriteLine("Failed to parse \"abc\" as an integer.");
    }


    // ==================== 6- FLOAT TO DECIMAL ====================

    float sum = 23.66f;

    // decimal theDecimalSum = sum; // compile error

    decimal theDecimalSum = (decimal)sum;

    Console.WriteLine();
    Console.WriteLine("Experiment 5 - FLOAT TO DECIMAL:");
    Console.WriteLine($"float to decimal : {theDecimalSum}");

    // float to decimal cannot be an implicit conversion because converting from float to decimal
    // they use different base (2 ,10) , may lose precision, so an explicit cast is required.
}


// ==================== PART C: VALUE VS. REFERENCE TYPES ====================

Console.WriteLine();
Console.WriteLine("=== PART C: Value vs. Reference Types ===");
Console.WriteLine();
RunValueVsReferenceDemo();

void RunValueVsReferenceDemo()
{
    // ==================== EXPERIMENT 1: STRUCT COPY SEMANTICS ====================

    Point p1 = new Point { X = 1, Y = 2 };
    Point p2 = p1;

    p2.X = 99;

    Console.WriteLine("Experiment 1 - Struct:");
    Console.WriteLine($"p1.X = {p1.X}");
    Console.WriteLine($"p2.X = {p2.X}");

    // Point is a value type, so assigning p1 to p2 copies the entire value.
    // Changes made to p2 do not affect p1.


    // ==================== EXPERIMENT 2: CLASS REFERENCE SEMANTICS ====================

    Order o1 = new Order
    {
        OrderId = 1001,
        CustomerName = "Aya",
        Quantity = 3,
        UnitPrice = 200m,
        TotalPrice = 0m,
        IsPaid = false,
        DiscountPercent = 10,
        ShippingCity = "Menoufia",
        Priority = 'H',
        ItemCode = 123456789L
    };

    o1.CalculateTotal();

    Order o2 = o1;

    o2.IsPaid = true;

    Console.WriteLine();
    Console.WriteLine("Experiment 2 - Class:");
    Console.WriteLine($"o1.IsPaid = {o1.IsPaid}");
    Console.WriteLine($"o2.IsPaid = {o2.IsPaid}");

    // Order is a reference type, so assigning o1 to o2 copies the reference,
    // not the object itself. Both variables refer to the same object on the heap.


    // ==================== OBJECT REFERENCE ====================

    object boxedOrder = o1;

    // No boxing happens here because Order is a reference type.
    // The object variable simply stores the same reference.

    Order o3 = (Order)boxedOrder;

    Console.WriteLine(
        $"ReferenceEquals(o1, o3): {object.ReferenceEquals(o1, o3)}"
    );

    o2.PrintSummary();

    // The summary reflects the change made through o2 because
    // o1 and o2 refer to the same Order object.


    // ==================== Explanation ====================

    // value types store their actual values, reference-type variables store references to objects.
    // value-type assignment copies the value, so the two variables have its own copy.
    // reference-type assignment copies the reference, so both variables point to the same object on the heap.
    // assigning a reference type to an object variable does not create a new object; it stores the same reference.
}

// ==================== PART D: SCOPE & OPERATORS ====================

Console.WriteLine();
Console.WriteLine("=== PART D: Scope & Operators ===");
Console.WriteLine();


// ==================== D1 - SCOPE ====================

// Field scope

ScopeTest test = new ScopeTest();

test.Method1();
test.Method2();


// Method scope

MethodScope();


// Block scope

for (int i = 0; i < 3; i++)
{
    int inside = i * 10;

    Console.WriteLine($"i = {i}, inside = {inside}");
}

// Console.WriteLine(i);
// Compile error because i has block scope and cannot be accessed outside the for-loop.

// Console.WriteLine(inside);
// Compile error because inside has block scope and cannot be accessed outside the loop.


// ==================== D2 - COMPOSITE ASSIGNMENT OPERATORS ====================

Console.WriteLine();
Console.WriteLine("D2 - Composite Assignment Operators");

int total = 100;

total += 5;
Console.WriteLine($"After += 5 : {total}");

total -= 10;
Console.WriteLine($"After -= 10 : {total}");

total *= 2;
Console.WriteLine($"After *= 2 : {total}");

total /= 5;
Console.WriteLine($"After /= 5 : {total}");

total %= 3;
Console.WriteLine($"After %= 3 : {total}");

// total += 5; is equivalent to total = total + 5;


// ==================== D3 - BITWISE OPERATORS ====================

Console.WriteLine();
Console.WriteLine("D3 - Bitwise Operators");

int a = 12;
int b = 10;

int andResult = a & b;
int orResult = a | b;
int xorResult = a ^ b;

Console.WriteLine($"a & b = {andResult}");
Console.WriteLine($"a | b = {orResult}");
Console.WriteLine($"a ^ b = {xorResult}");

// a = 1100
// b = 1010
// a & b = 1000 = 8
// a | b = 1110 = 14
// a ^ b = 0110 = 6

// & compares bits of integers,
// while && works with boolean conditions and does not evaluate the right side when the left side is false.



// ==================== PART F: LEETCODE 136 - SINGLE NUMBER ====================

Console.WriteLine();
Console.WriteLine("=== PART F: LeetCode 136 - Single Number ===");

int[] nums1 = { 4, 1, 2, 1, 2 };
int[] nums2 = { 2, 2, 1 };

Console.WriteLine($"Single number in [4, 1, 2, 1, 2] = {FindSingleNumber(nums1)}");
Console.WriteLine($"Single number in [2, 2, 1] = {FindSingleNumber(nums2)}");

int FindSingleNumber(int[] nums)
{
    int result = 0;

    // 4^1^2^1^2 == 4^ (1^1) ^ (2^2) == 4^0^0 = 4
    //XOR-ing every number together cancle pairs that appear twice
    // only the odd number remain

    for (int i = 0; i < nums.Length; i++)
    {
        result = result ^ nums[i];
    }

    return result;
}

// ==================== METHODS ====================

void MethodScope()
{
    int number = 50;

    Console.WriteLine($"Local number = {number}");

    // number cannot be accessed outside this method because
    // it has method scope.
}


// ==================== CLASS ====================

class ScopeTest
{
    private int number = 100;

    public void Method1()
    {
        Console.WriteLine($"Field from Method1 = {number}");
    }

    public void Method2()
    {
        Console.WriteLine($"Field from Method2 = {number}");
    }
}


// ==================== STRUCT ====================

struct Point
{
    public int X;
    public int Y;
}






