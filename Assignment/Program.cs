using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAssignment
{
    class Program
    {
        // Class-level field for scope demonstrations
        static int classField = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           C# FUNDAMENTALS - ASSIGNMENT WITH ANSWERS                ║");
            Console.WriteLine("║                      20 Questions                                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝\n");



            #region Question 1: Regions  ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: REGIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //    How do they help in code organization?
            //
            // it work as a remark or short desceription or definde for each specific bulk of codes,
            // it is useful for readabilit and so we can get to the code easily as it doesn't affect on code 
            // ══════════════════════════════════════════════════════════════════════

            //Nested Region Example

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 2: Variable Declaration - Explicit vs Implicit  ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.
            //
            // ══════════════════════════════════════════════════════════════════════

            // EXPLICIT DECLARATION 
            // in expilicit variables , we specifiy the data type in declaration
            // int x = 30;
            // string y = "Mohamed";


            // IMPLICIT DECLARATION 
            // in implicit variables , the data type is determinded by the compiler at
            // complie time based on the data type assigned to the variable
            // var x = 30;      =>    integer
            // var y = "Mohamed";   => string

            #endregion

            #region Question 3: Constants  ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?
            // we use const instead of regular variable in case we want not to change the value during the coding,
            // as const declared , it can not be reassigned to new value which prevent bugs in some projects as 
            // more easier to maintaince and debug
            // most useful advantage is the optimaize the performane as the value of const is known,
            // it doesn't need to allocate in memory at runtime and the const compiled directly in IL
            // ══════════════════════════════════════════════════════════════════════
            // Constant examples
            // const x = 30;
            // const y = "Mohamed";


            #endregion

            #region Question 4: Class-level vs Method-level Scope  ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.
            //
            // the diff between CLASS-LEVEL and METHOD-LEVEL SCOPE is the lifetime and access scope,
            // ** Class Level can be accessed in the main object and life time is during the existing
            // of the object

            // ** Method Level can be accessed in the same method only and can not be accessed outside the method,
            // and life time is when it called and dies when it finshed


            // Ex:

            // Class ClassLevel {
            //                  int Clas = 200;  ====> No Error ( Class Level)
            //                  int Meth = 100;  ====> Error ( Method Level )
            //
            // void MethodLevel() {
            //                          int Meth = 1000;   === > No Error ( Method Level )
            //                          int Clas = 2000;   === > No Error ( Class Level)
            //                     }
            //
            //                  }
            //
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 5: Block-level Scope  ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 5: BLOCK-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is block-level scope? Give an example showing a variable that 
            //    is only accessible within a specific block.
            //
            // it's a scope which any variables is only accessiable inside its scope , such like If & For loop

            // if ( 1 = 1 ) {
            //                 var x = 50;
            //                      x = 20;    === > No Error
            //               }
            //     x = 30; ====> Error
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 6: Variable Lifetime - Local vs Static ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable lifetime? Explain the lifetime of local variables 
            //    vs static variables.
            //
            // it is the period that the variable available in memeory during program running.
            //
            // ** lifetime of local variables : happen in run time begain with function
            // or object excution and end with finish excution

            // ** lifetime of static variables : began with the program start and end with program stop
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 7: Garbage Collector ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 7: GARBAGE COLLECTOR
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the Garbage Collector in C#? How does it affect the 
            //    lifetime of objects?
            //
            // It is an automatic remover of objects that are no longer in use (Not reachable) .
            // it inhance the performance by ending the lifetime of objects  that are not reachable or not use by any variable or 
            // object and remove them from the memory
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 8: Variable Shadowing ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 8: VARIABLE SHADOWING
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable shadowing in C#? Does C# allow shadowing in 
            //    nested blocks within the same method?
            //
            // Shadowing is declaring variable in inner scope (Method) has the same name of its outer scope (Class),
            // and C# allows shadowing by using (this) key word to access the inner scope variable
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 9: C# Naming Rules  ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 9: C# NAMING RULES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List five rules that must be followed when naming variables in C#.
            //
            // 1 - must start with letter
            // 2 - must not start with numbers
            // 3 - must be carreful with cas sensitive ( name !=  Name != NAME )
            // 4 - must not contain spaces
            // 5 - could start with _ or @ (when necessary )
            // 6 - must not contain special chars  or reserved ke words
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 10: Naming Conventions  ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 10: NAMING CONVENTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What naming conventions are recommended for: (a) local variables, 
            //    (b) class names, (c) constants?
            //
            //   Local Variables  : camelCase  == > Ex: isInteger , userName , userLocation .
            //   Class Names , Constants : PascalCase  == > Ex: NamingRuleClass , CalculateTax
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 11: Error Types ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 11: ERROR TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Compare and contrast syntax errors, runtime errors, and logical 
            //    errors. Provide an example of each.
            //
            // Syntax Error : errors detected by complier before runing
            // Ex.  int x = "Mohamed";  == > Error type not match
            //
            // Runtime Error : errors are being detected during running and cuases crash of the program
            // Ex.  int[] mmm = {1,2,3};
            // Console.WriteLine(mmm[27]); == > Error out of array range
            //
            // Logical Error : Can not be detected by compiler and the program is running well but gives wron results
            // Ex.  int sum = 1 + 2 + 3;
            //      int avg = sum * 3;  === > No Error but wrong result
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 12: Exception Handling Importance  ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is exception handling important in C#? What would happen if 
            //    you don't handle exceptions?
            //
            // Exception prevent program from crushing by control errors . if we do not handle errors ,
            // the prpgram will crushed and a complex errors will be appeared.
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 13: try-catch-finally ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 13: TRY-CATCH-FINALLY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example demonstrating try-catch-finally. Explain when 
            //    the finally block executes.
            //try
            //{
            //    int x = int.Parse("Mohamed");
            //    Console.WriteLine(x);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"Error : {ex.Message}");
            //}
            // 
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 14: Common Built-in Exceptions  ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List and explain five common built-in exceptions in C# with 
            //    scenarios when each would occur.
            //
            //  1- DividedByZeroExc.
            // Ex. int x = 10/0;
            //
            // 2- OutOfRangeExc.
            // Ex. int[] x = {1,2,3};
            // Console.WriteLine(x[5]);
            //
            // 3- NullReferencesExc.
            // Ex. string x  = null;
            // x.ToUpper();
            //
            // 4- FormateExc.
            // Ex. int.Parse("Moahmed");
            //
            // 5- NullArgumentExc.
            // Ex. Method(null,5,10)
            // 
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 15: Multiple catch Blocks ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 15: MULTIPLE CATCH BLOCKS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is the order of catch blocks important when handling multiple 
            //    exceptions? Write code showing correct ordering.
            //
            // because in runtime compiler check the code sequentially and excute the first exc. and the next etc.
            //
            //try
            //{
            //    int x = int.Parse("Mohamed");
            //    Console.WriteLine(x);
            //    int y = 10 / 0;
            //    Console.WriteLine(y);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"Error : {ex.Message}");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Error : {ex.Message}");
            //}
            //
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 16: throw Keyword ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 16: THROW KEYWORD
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between 'throw' and 'throw ex' when 
            //    re-throwing an exception? Which one preserves the stack trace?
            //
            // The diff is in Location , throw keeps original location while throw ex losses it.
            // throw keeps the original stack trace while throw ex lost it
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 17: Stack and Heap Memory ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 17: STACK AND HEAP MEMORY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the differences between Stack and Heap memory in C#. 
            //    What types of data are stored in each?
            //
            // Stack : very fast - samll size - automatic manage - locate the variable
            // Ex. variables - methods
            //
            // Heap : slower than stach - large size - under GC manage - refer to the variable value
            // Ex. String - array 
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 18: Value Types vs Reference Types ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example showing how value types and reference types 
            //    behave differently when assigned to another variable.
            //
            // Value Types :
            // int x = 30;
            // int b = x;
            // b = 15;
            // x != 15;    Every one is independent
            //
            // Reference Type :
            // Point x = new Point();
            // Point y = x;
            // y = 20;
            // x = 20;    Both share the same reference (object)
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 19: Object in C# ##
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 19: OBJECT IN C#
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is 'object' considered the base type of all types in C#? 
            //    What methods does every type inherit from System.Object?
            //
            // Because all other types are derived from .
            // Methods like : ToString () - GetType() - Equals() - GetHashCode()
            // ══════════════════════════════════════════════════════════════════════

            #endregion

        }


#endregion
    }

    
}