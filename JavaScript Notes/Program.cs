using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaScript_Notes
{

    /*
      ***********************************************************************************************************************************************************************

                                                           SECTION : 01        JAVASCRIPT

***********************************************************************************************************************************************************************

** JAVASCRIPT :
 |- It is the programming language of HTML and Web.
 |- It can change HTML content (innerHTML) with a method called "document.getElementById("id")".
 |- It can change HTML style CSS as well as  HTMl attributes .
 |- It can hide/show HTML elements.
 |- It is case sensitive.
 |- Lower Camel Case is used in JavaScript.
 |- It uses "Unicode" character set. Unicode covers almost all the characters, punctuations, and symbols in the world.

** OUTPUT : ( TO DISPLAY ) 
   |- Writing into an HTML element, using "innerHTML".         --> Most common way to show data.
   |- Writing into the HTML output using "document.write()".   --> used for testing purpose. It deletes all existing HTML when HTML document is fully loaded.
   |- Writing into an alert box, using "window.alert           --> used for alert boxes.
   |- Writing into the browser console, using "console.log()". --> used for debugging purposes.

** SYNTAX :
    |- In HTML JavaScript programs are executed by the Web browser.
    |- JavaScript Statements are composed of :

          |- Values : It is of two type :-
              |- (1) Fixed Values    --> literals
              |- (2) Variable values --> variables

          |- Operators
          |- Expressions
          |- Keywords
          |- Comments

** STATEMENTS :
    |- These are the "instructions" to be "executed" by the web browser.
    |- Semicolon (;) seperate JavaScript statements.
    |- It is also know as java Script Code.
    |- JavaScript keywords are reserved words. Reserved words cannot be used as names for variables.

** VARIABLE :
    |- These are the containers for storing data value.
    |- "var" keyword is used to declare a variable. (e.g, var car = "Volvo";)
    |- All JavaScript variable must be identified with unique names. These unique names are calles Identifiers.
    |- It is good practice to declare all variables at the beginning of the script.
    |- We can declare multiple variables in one statement (e.g, var person = "Shubham" , car = "BMW" , Age = "23";) 
    |- A variable without a value will have the value "undefined".
    |- If we re-declare a variable , it will not lose it's value.

Note :- var x = "S" + 2 + 3 ; --> It's output will be like S23.
Note :- var y = 2 + 3 + "S" ; --> I's output will be like 5S.
Note :- JavaScript evaluates expression from left to right.

** DATA TYPES :
    |- In JS data types are dynamic i.e 
                var x ;                 --> Here x is Undefined
                var x = 5 ;             --> Here x is Number
                var x = "Shubham" ;     --> Here x is String
          
    |- A string is a series of characters like ("shubham saurabh")  or like ('Shubham Saurabh')   

Note :- Numbers can be written with or without decimals.
Note :- Extra large and Extra Small numbers are written with scientific (exponential) notation.
                |- var x = 123e5  --> 12300000 is the Output
                |- var x = 123e-5 --> 0.00123  is the Output

Note :- In JavaScipt Null is "nothing". It's Data Type is an "object".
Note :- We can empty  an object by setting it to undefined.
Note :- "Null" and "Undefined" are equal in value and different in type.
Note :- The "typeof" operators returns "object" for array because in JS "arrays are objects".


**********************************************************************************************************************************************************************
                                                                    SECTION : 02
**********************************************************************************************************************************************************************


** FUNCTIONS :

    |- Syntax --> function <function_name> (param1 , param2) { code to be executed }
        e.g,
         |-    function myFunction ( p1, p2 )
                {
                    return p1 * p2 ;
                }

    |- By using functions we can reuse our code.

** OBJECTS :

    |-       " name : value " pair --> { name : "Shubham" , Age: 23 }; 
     
        Note :- These "name : values" pairs in JS are known as properties.

    |- e.g, var x = { Name : "Shubham" , Age : "23" };

    |- We define JS objects with object literals.

    |- These are containers for named values.

    |- We can access objects properties  by two ways :
    
           (1) objectName.propertyName

           (2) objectName["propertyName"] 

    |- We can access objects method by this method :
          
           (1) objectName.methodName()

Note :- Method is nothing but function definition stored as a proprty value.

Note :- Do not declare " Strings , Numbers , Booleans " as objects. It is because they slow down execution speed.

        i.e, var x = new String() ;  --> Declares x as a String Object
             var x = new Number() ;  --> Declares x as a Number Object
             var x = new Boolean() ; --> Declares x as a Boolean Object 

** SCOPES :
    |- It determines the accessibility (visibility) of variables .
    
    |- In JS there are two type of Scope : 

        (1) Local Scope : 

              |- Variables declared within a JS Function , become LOCAL to the function.
              |- Local variable have  " Local Scope " .

                 e.g,  function myFunction()
                         {
                              var carName = " BMW " ;

                            // Code here can use carName  , but code outside this function can not use carName.
                         }

             |- Same variable names can be used in other functions in the case of locxal variable.

             |- Local variables created when function starts, and deleted when the function is completed.

        (2) Global Scope :

             |- variables declared outside  a function becomes the GLOBAL.
             |- It has a GLOBAL SCOPE.
             |- All Scripts and Functions on a web page can access it.

Note :- In JS objects and functions are also variables.


       *(3) Automatically Global :
            |- If we assign a value to a variable that has not been declared then it will automatically become a GLOBAL variable.
 
              i.e,      
                               myfunction();

                             // CODE here can use carName 
                                
                             function myFunction()
                                {
                                       carName = "BMW" ;
                                }   

Note :- Do NOT create global variables unless it is required.
Note :- In "STRICT MODE" automatically global variables will fail.

            |- Global Variables in HTML :

                     |- In HTML it is window object.
                            i.e, 
                                     var carName  = "volvo";
                                 
                                  // CODE here can use window.carName

Note :- Global Variables (functions) can overwrite window variables (functions)
Note :- Any function , including window object, can overwrite the Global variables and functions.
Note :- Function arguments work as local variables inside functions.


** STRINGS :

    |- The length of a string is found in the built in property "length".

          e.g, var x = "Shubham"
               var y = x.length    --> OUTPUT : 7

   |- Special characters :

          |-  e.g, 
                    var x = " My Name is "shubham" saurabh singh";  --> Now this would return only : My Name is

              ==> Here we should use 
      
                   var x = " My Name is \"Shubham\" saurabh singh"; --> Now this will return : My Name is shubam saurabh singh

Note :- \ (escape character) is used here to avoid this problem.

Note :- \' --> Used for Single quote (i.e, var x = 'It\'s me ';)
        \" --> Used for Double quotes 
        \\ --> backslash


Note :-  \b --> Backspace
         \r --> Carriage Return
         \f --> Form Feed
         \t --> Horizontal Tabulator
         \v --> vertical Tabulator
 
Note :- Strings can also be defined as Objects with a new Keyword.
         i.e, 
              var y = new String("Shubham")  --> typeof y will return onbject in this case.

Note :- Don't create strings as objects because it will slow down execution speed.

Note :- Objects can't be compared.


**********************************************************************************************************************************************************************
                                                                    SECTION : 03
**********************************************************************************************************************************************************************

 ** STRING METHODS :
    
    (1) "length" property returns the length of string.   e.g, var x = "shubham";
                                                               var y = x.length ;      --> OUTPUT : 7

    (2) Finding a String in a String :

         |- " indexof() " method returns the index of the first occurence of a specified text in a string.

                    e.g,
                           var str  = "please locate where 'locate' occurs!" ; 
                           var pos  =  str.indexof("locate");                          --> OUTPUT : 7
  


        |- " lastIndexOf " method returns the index of last occurrence of a specified text in a string.

                    e.g,
                           var str  = "please locate where 'locate' occurs!" ; 
                           var pos  =  str.lastIndexof("locate");                          --> OUTPUT : 21

                    e.g, 
                            var str  = "please locate where 'locate' occurs!" ; 
                            var pos  =  str.lastIndexof("locate", 15);                     --> OUTPUT : 21

                Note:- Here both method accepts parameter as the starting position for the search  
                  

 Note :- Both the indexof(), and the lastIndexOf() methods return -1 if the text is not found.

 Note :- JavaScript counts positions from zero.

                   
     (3) Searching for a String in a String : 
       
          |- " search() " method searches a string for a specified value and returns the position of the match.
                                                                   
                 e.g,
                           var str  = " please locate where 'locate' occurs! " ; 
                           var pos  =  str.search("locate");                          --> OUTPUT : 7

          Note :- It is  similar to the indexof(). 

          Note :- Difference is :- The search() method cannot take a second start position argument.

                                   The search() method can take much more powerful search values (regular expressions).

     (4) Extracting String Parts :

         (a) slice(start, end) :

              |- It extracts a part of a string and returns the extracted part in a new string.

              |- This method takes 2 parameters :  the starting index (position), and the ending index (position). 
 
                  e.g, 
                      var str = "Apple, Banana, Kiwi";
                      var res = str.slice(7, 13);           --> OUTPUT : Banana

              |- If a parameter is negative, the position is counted from the end of the string.

                    e.g, 
                            var str = "Apple, Banana, Kiwi";
                            var res = str.slice(-12, -6);     --> OUTPUT : Banana

              |- If we omit the second parameter, the method will slice out the rest of the string :

                   e.g, 
                            var str = "Apple, Banana, Kiwi";
                            var res = str.slice(7);             --> OUTPUT : Banana, Kiwi

                    e.g, 
                            var str = "Apple, Banana, Kiwi";
                            var res = str.slice(-12);             --> OUTPUT : Banana, Kiwi

              Note :- Negative positions do not work in Internet Explorer 8 and earlier.

          (b) substring(start, end) :
            
              |- It is similar to slice().
     
              |- The difference is that substring() cannot accept negative indexes.

          (c) substr(start, length) :
               
              |- It is similar to slice().

              |- The difference is that the second parameter specifies the "length" of the extracted part.

                e.g, 
                       var str = "Apple, Banana, Kiwi";
                       var res = str.substr(7, 6);                                --> OUTPUT : Banana

              |- The second parameter can not be negative as it defines the length.


       (5) Replacing String Content :
           
              |- The "replace()" method replaces a specified value with another value in a string.

                 e.g, 
                      str = "Please visit Microsoft!";
                      var n = str.replace("Microsoft", "W3Schools");                 --> OUTPUT : please visit W3Schools
 
              |- It does not change the string it is called on. It returns a new string.
 
              |- By default, the replace() function replaces only the first match.    
             
              |- To replace all matches, use a regular expression with a " /g " flag (global match):

                  e.g, 
                        str = "Please visit Microsoft and Microsoft!";
                        var n = str.replace(/Microsoft/g, "W3Schools");                    --> OUTPUT : Please visit W3scool and W3school

     
              |- By default, the replace() function is case sensitive. Writing MICROSOFT (with upper-case) will not work.

                   e.g,
                         str = "Please visit Microsoft!";
                         var n = str.replace("MICROSOFT", "W3Schools");    --> This will not work.

             |- To replace case insensitive, use a regular expression with an " /i " flag (insensitive):

                    e.g,
                         str = "Please visit Microsoft!";
                         var n = str.replace(/MICROSOFT/i, "W3Schools");

       (6) Converting to Upper and lower Case :

               |- A string is converted to upper case with toUpperCase()
                   
                      e.g,
                                  var text1 = "Hello World!";       
                                  var text2 = text1.toUpperCase();          --> OUTPUT : HELLO WORLD

               |- A string is converted to lower case with toLowerCase()

                    e.g, 
                                var text1 = "Hello World!";       
                                var text2 = text1.toLowerCase();            --> OUTPUT : hello world

      (7) The conacta() Method :
          
            |- concat() joins two or more strings.
                e.g,
                     var text1 = "Hello";
                     var text2 = "World";
                     var text3 = text1.concat(" ", text2);                     --> OUTPUT : Hello World


            Note :- All string methods return a new string. They don't modify the original string.
                    Formally said: Strings are immutable: Strings cannot be changed, only replaced.

      (8) Extracting String Characters :
             
            |- There are two safe methods for this 

             (a) charAt(position) :

                    |- It returns the character at a specified index(position) in a string.
                         
                              e.g, 
                                           var str = "HELLO WORLD";
                                                     str.charAt(0);            --> OUTPUT : H


            (b) charCodeAt(position)
 
                  |- It returns the unicode of the character at a specified index in a string.

                              
                              e.g, 
                                           var str = "HELLO WORLD";
                                                     str.charCodeAt(0);            --> OUTPUT : 72

       (9) Accessing a String as an Array is Unsafe :

           e.g,
                  var str = "HELLO WORLD";
                  str[0];                        --> OUTPUT : H

             |- This is unsafe and unpredictable
             |- It does not work in all browsers (not in IE5, IE6, IE7)
             |- It makes strings look like arrays (but they are not)
             |- str[0] = "H" does not give an error (but does not work)


            Note :- If we want  to read a string as an array then convert it to an array first.

        (10) Converting a String to an Array :

              |- A text can be converted to an array with the " split() " method.

                    e.g,
                             var txt = "Hello";       // String
                             txt.split("");                                --> OUTPUT :   H
                                                                                          e 
                                                                                          l
                                                                                          l
                                                                                          o   


**********************************************************************************************************************************************************************
                                                                    SECTION : 04
**********************************************************************************************************************************************************************

** NUMBERS :
    
     |- JS Numbers are always 64-bit floating point.

     |- NaN : Not a Number

     |-  " typeof NaN; " is number
 
     |- " typeof Infinity; " is number

     |- JavaScript interprets numeric constants as hexadecimal if they are preceded by 0x.

              e.g,  
                       var x = 0xFF;           // x will be 255

    Note :- Never write a number with a leading zero (like 07).
            Some JavaScript versions interpret numbers as octal if they are written with a leading zero.

     |- By default, JavaScript displays numbers as base 10 decimals.

     |- We can use  " toString() " method to output numbers as base 16 (hex), base 8 (octal), or base 2 (binary).

                e.g, 
                          var myNumber = 128;
                          myNumber.toString(16);  // returns 80
                          myNumber.toString(8);   // returns 200
                          myNumber.toString(2);   // returns 10000000


      |- Numbers can be created as an objects.

            e.g,
                    var x = new Number(123);       //typeof y returns object 


         Note :- Do not create Number objects. It slows down execution speed.




** NUMBER METHODS :

     |- JavaScript treats primitive values (like 3.14 or 2014) as objects when executing methods and properties.

    (1) The " toString() " Method :

         |- toString() returns a number as a string.
    
         e.g,
                  var x = 123;
                  x.toString();            // returns 123 from variable x
                  (123).toString();        // returns 123 from literal 123
                  (100 + 23).toString();   // returns 123 from expression 100 + 23

    (2) The toExponential() Method :
          
         |- The " toExponential() "  returns a string, with a number rounded and written using exponential notation.

           e.g, 
                 var x = 9.656;
                 x.toExponential(2);     // returns 9.66e+0 
                 x.toExponential(4);     // returns 9.6560e+0
                 x.toExponential(6);     // returns 9.656000e+0

    (3) The toFixed() Method :

         |- The "  toFixed() " returns a string, with the number written with a specified number of decimals:

             e.g, 
                 var x = 9.656;
                 x.toFixed(0);              // returns 10
                 x.toFixed(2);             // returns 9.66    --> It is perfect for working with money
                 x.toFixed(4);            // returns 9.6560 
                 x.toExponential(6);     // returns 9.656000

    (4) The toPrecision() Method :
         
         |- The  " toPrecision() " returns a string, with a number written with a specified length:

                e.g, 
                    var x = 9.656;
                    x.toPrecision();                // returns 9.656
                    x.toPrecision(2);              // returns 9.7  --> It is perfect for working with money
                    x.toPrecision(4);             // returns 9.656 
                    x.toPrecision(6);            // returns 9.65600         

    (5) The valueOf() Method :

          |- The  " valueOf() " returns a number as a number.  
              
                          e.g,
                                  var x = 123;
                                  x.valueOf();            // returns 123 from variable x
                                  (123).valueOf();        // returns 123 from literal 123
                                  (100 + 23).valueOf();   // returns 123 from expression 100 + 23
                       
    (6) Converting Variables to Numbers :
     
         |- There are three global JS methods for this :
           
               (a) The Number() Method :

                    |- Number() can be used to convert JavaScript variables to numbers

                    |- It returns a number , converted from it's argument.

                           e.g,
                                  x = true;
                                  Number(x);        // returns 1

                                  x = false;     
                                  Number(x);        // returns 0

                                  x = new Date();
                                  Number(x);        // returns 1404568027739

                                  x = "10"
                                  Number(x);        // returns 10

                                  x = "10 20"
                                  Number(x);        // returns NaN

  
                 (b) The parseInt() Method :

                      |- It parses a string and returns a whole number. Spaces are allowed. Only the first number is returned:

                             e.g, 
                                   parseInt("10");         // returns 10
                                   parseInt("10.33");      // returns 10
                                   parseInt("10 20 30");   // returns 10
                                   parseInt("10 years");   // returns 10
                                   parseInt("years 10");   // returns NaN --> It is because number can't be converted.

                (c) The parseFloat() Method :
  
                    |- It parses a string and returns a number. Spaces are allowed. Only the first number is returned:
                  
                         e.g, 
                                   parseInt("10");         // returns 10
                                   parseInt("10.33");      // returns 10.33
                                   parseInt("10 20 30");   // returns 10
                                   parseInt("10 years");   // returns 10
                                   parseInt("years 10");   // returns NaN --> It is because number can't be converted.



**********************************************************************************************************************************************************************
                                                                    SECTION : 05
**********************************************************************************************************************************************************************
                      
** MATH :
   
   (1) Math.round() :

        |- Math.round(x) returns the value of x rounded to its nearest integer:  

            e.g, 
                        Math.round(4.7);    // returns 5
                        Math.round(4.4);    // returns 4
   
   (2) Math.pow() :
 
        |- Math.pow(x, y) returns the value of x to the power of y:

           e.g, 
                       Math.pow(8, 2);      // returns 64

   (3) Math.sqrt() :

       |- Math.sqrt(x) returns the square root of x:

            e.g, 
                       Math.sqrt(64);      // returns 8


   (4) Math.abs() :

       |- Math.abs(x) returns the absolute (positive) value of x:

            e.g, 
                     Math.abs(-4.7);     // returns 4.7

   (5) Math.ceil() :

        |- Math.ceil(x) returns the value of x rounded up to its nearest integer:

           e.g,
                   Math.ceil(4.4);     // returns 5

   (6) Math.floor() :

       |- Math.floor(x) returns the value of x rounded down to its nearest integer:

            e.g, 
                  Math.floor(4.7);    // returns 4
   
   (7) Math.min() and Math.max() :

       |- Math.min() and Math.max() can be used to find the lowest or highest value in a list of arguments:

            e.g, 

                 Math.min(0, 150, 30, 20, -8, -200);  // returns -200

                 Math.max(0, 150, 30, 20, -8, -200);  // returns 150

   (8) Math.random() :

         |- Math.random() returns a random number between 0 (inclusive),  and 1 (exclusive):

                 e.g,  
                              Math.random();     // returns a random num



         |- This JavaScript function always returns a random number between min (included) and max (excluded):

                 e.g,
                         fuction getRndInteger ( max , min)
                            {

                                  return Math.floor(Math.random() * (max -min)) + min ;
                            }

       |- This JavaScript function always returns a random number between min and max (both included):

                   e.g, 

                          function getRndInteger ( max,min)
                            {
                                     return Math.floor(Math.random() * (max - min + 1)) + min ;
                            }

 
**********************************************************************************************************************************************************************
                                                                    SECTION : 06
**********************************************************************************************************************************************************************

** DATES :

    |- A JavaScript date can be written as a string:
          
             Mon Oct 09 2017 18:39:12 GMT+0530 (India Standard Time)

    |- e.g, 

                  <p id="demo"></p>

                  <script>
                           document.getElementById("demo").innerHTML = Date();  // Date() will show the current date
                  </script>   

    |- Date objects are created with the " new Date() " constructor.     

         e.g,

                 new Date()
                 new Date(milliseconds)
                 new Date(dateString)
                 new Date(year, month, day, hours, minutes, seconds, milliseconds)       

    Note :- JavaScript counts months from 0 to 11. January is 0. December is 11    

    Note :- When we display a date object in HTML, it is automatically converted to a string, with the " toString() " method.

    Note :- Date objects are static.

       
** DATE METHIDS :
    
    (1) getDate()       -->    Get the day as a number (1-31)
    (2) getDay()        -->    Get the weekday as a number (0-6)  **Note :- sunday is O and saturday is 6
    (3) getFullYear()   -->    Get the four digit year (yyyy)
    (4) getHours()      -->    Get the hour (0-23)
    (5) getMilliseconds -->    Get the milliseconds (0-999)
    (6) getMinutes()    -->    Get the minutes (0-59)
    (7) getMonth()      -->    Get the month (0-11)
    (8) getSeconds()    -->    Get the seconds (0-59)
    (9) getTime()       -->    Get the time (milliseconds since January 1, 1970)



    

 
**********************************************************************************************************************************************************************
                                                                    SECTION : 07
**********************************************************************************************************************************************************************

** ARRAYS :

    |- Arrays are Objects.
    |- typeof operator returns an object for arrays.


  (1) Adding array elements :

         |- var fruits = ["Banana", "Orange", "Apple", "Mango"];
            fruits.push("Lemon");                                       // adds a new element (Lemon) to fruits

    
         |- var fruits = ["Banana", "Orange", "Apple", "Mango"];
            fruits[fruits.length] = "Lemon";                            // adds a new element (Lemon) to fruits
                  

        Note :- Adding elements with high indexes can create undefined "holes" in an array.

                     e.g, 
                             var fruits = ["Banana", "Orange", "Apple", "Mango"];
                             fruits[6] = "Lemon";  

        Note :- JS does not support arrays with " named index " . In JS, arrays  always  use " numbered index ".

        Note :- In JS objects are named index and arrays are numbered index.

        Note :- Arrays with named index are known as " associative array " .


   (2) When to use Arrays and when to use Objects :
        
             |- objects  --> when you want the element names to be strings (text).

             |- arrays   --> when you want the element names to be numbers.

   (3) How to Recognize an Array :

           |-  e.g,

                        var fruits = ["Banana", "Orange", "Apple", "Mango"];

                        document.getElementById("demo").innerHTML = Array.isArray(fruits);   // returns true


           |- e.g, 
                        var fruits = ["Banana", "Orange", "Apple", "Mango"];

                        	fruits instanceof Array ;    // returns true

   (4) Converting an Array to String :

         |- e.g,

            var fruits = ["Banana", "Orange", "Apple", "Mango"];
            document.getElementById("demo").innerHTML = fruits.toString();


        |- Join() method joins all the elements of array into a string .

             e.g,
                  var fruits = ["Banana", "Orange", "Apple", "Mango"];
                 document.getElementById("demo").innerHTML = fruits.join(*);  // OUTPUT : Banana * Orange * Apple * Mango

  (5) POPPING and PUSHING :
  
       (a) Popping :
            |- It removes the " last " element from an array.

                      e.g,
                                var fruits = ["Banana", "Orange", "Apple", "Mango"];
                                fruits.pop();                                            // Removes the last element ("Mango") from fruits


       (b) pushing :
              |- The push() method adds a new element to an array (at the end).

                       e.g,
                              var fruits = ["Banana", "Orange", "Apple", "Mango"];
                               fruits.push("Kiwi");                                         //  Adds a new element ("Kiwi") to fruits

                 

              |- The push() method returns the new array length

                    e.g, 
                            var fruits = ["Banana", "Orange", "Apple", "Mango"];
                            var x = fruits.push("Kiwi");                                 //  the value of x is 5
               

       (c) Shifting :

              |- It is similar to popping , but it  " works on the first element " instedof last .
                   e.g,
                            var fruits = ["Banana", "Orange", "Apple", "Mango"];
                            fruits.shift();                                          // Removes the first element "Banana" from fruits


       (d) Unshifting :

             |-  IT is similar to pushing , but it "works on the first element " insted of last.
                      e.g,
                  var fruits = ["Banana", "Orange", "Apple", "Mango"];
                  fruits.unshift("Lemon");                                      // Adds a new element "Lemon" to fruits


  (6) CHANGING ELEMENTS :

        |- e.g,
                  var fruits = ["Banana", "Orange", "Apple", "Mango"];
                  fruits[0] = "Kiwi";                                              // Changes the first element of fruits to "Kiwi"


  (7) SPLICING AN ARRAY :

       |- The splice() method can be used to add new items to an array.

             e.g,
                      var fruits = ["Banana", "Orange", "Apple", "Mango"];
                      fruits.splice(2, 0, "Lemon", "Kiwi");                  // OUTPUT : Banana,Orange,Lemon,Kiwi,Apple,Mango


              HERE :-  The first parameter (2) defines the position where new elements should be added (spliced in).
                       The second parameter (0) defines how many elements should be removed.
                       The rest of the parameters ("Lemon" , "Kiwi") define the new elements to be added.



     |- It can also be used to remove elements from an array 

            e.g, 
                 var fruits = ["Banana", "Orange", "Apple", "Mango"];
                 fruits.splice(0, 1);                                           // Removes the first element of fruits

  (8) MERGING (Concatenating)  Arrays : 
     
       |- The concat() method creates a new array by merging (concatenating) existing arrays.

               e.g,
                    var myGirls = ["Cecilie", "Lone"];
                    var myBoys = ["Emil", "Tobias","Linus"];

                    var myChildren = myGirls.concat(myBoys);  
 
           Note : The concat() method does not change the existing arrays. It always returns a new array.

      |- Merging Three Arrays :

              e.g,
                      var arr1 = ["Cecilie", "Lone"];
                      var arr2 = ["Emil", "Tobias","Linus"];
                      var arr3 = ["Robin", "Morgan"];
                      var myChildren = arr1.concat(arr2, arr3);     // Concatenates arr1 with arr2 and arr3  


  (9) SLICING AN ARRAY :

         |- The slice() method slices out a piece of an array into a new array.

               e.g, 
                        var fruits = ["Banana", "Orange", "Lemon", "Apple", "Mango"];
                        var citrus = fruits.slice(1);                                  // Returns Orange,Lemon,Apple,Mango


             Note : The slice() method creates a new array. It does not remove any elements from the source array.


         |- It can also accept two arguments 
 
              e.g,

                            var fruits = ["Banana", "Orange", "Lemon", "Apple", "Mango"];
                            var citrus = fruits.slice(1,3);                                  // Returns Orange,Lemon

               Note :-  Here "1" is included and "3" is excluded.

         |- If the end argument is omitted, like in the first examples, the slice() method slices out the rest of the array.


   (10) Sorting and Reversing an Array :

            |- var fruits = ["Banana", "Orange", "Apple", "Mango"];
               fruits.sort();                                            // Sorts the elements of fruits 
               fruits.reverse();                                        // Reverses the order of the elements

   (11) Numeric sorting :

           |- var points = [40, 100, 1, 5, 25, 10];
              points.sort(function(a, b){return a - b});                // returns 1,5,10,25,40,100 --> Ascending order sorting 

           |- var points = [40, 100, 1, 5, 25, 10];
              points.sort(function(a, b){return b - a});                // returns 100,40,25,10,5,1 --> Descending order sorting 

  
  (12) Sorting Object Arrays :

          |- var cars = [
                          {type:"Volvo", year:2016},
                          {type:"Saab", year:2001},
                          {type:"BMW", year:2010}
                        ]

             displayCars();

               function myFunction() {
                cars.sort(function(a, b){return a.year - b.year});
               displayCars();
                 }

               function displayCars() {
               document.getElementById("demo").innerHTML =
               cars[0].type + " " + cars[0].year + "<br>" +
               cars[1].type + " " + cars[1].year + "<br>" +
               cars[2].type + " " + cars[2].year;
                 }


**********************************************************************************************************************************************************************
                                                                    SECTION : 08
**********************************************************************************************************************************************************************
  
  ** JSON :

         |- It stands for JavaScript Object Notation
         |- Language Independent
         |- Lightweight data format
         |- It is used to exchange data to/from a web server 

                  e.g, 
                          "employees":[
                                         {"firstName":"John", "lastName":"Doe"}, 
                                         {"firstName":"Anna", "lastName":"Smith"},
                                         {"firstName":"Peter", "lastName":"Jones"}
                                      ]          
  (1) JSON Syntax rules :
        |- Data is in name/value pairs
        |- Data is separated by commas
        |- Curly braces hold objects
        |- Square brackets hold arrays

  (2) Converting a JSON Text to a JavaScript Object :
      
         |- When receiving data from a web server, the data is always a string.

        |- Parse the data with JSON.parse(), and the data becomes a JavaScript object.


              var text = '{ "employees" : [' +
                         '{ "firstName":"John" , "lastName":"Doe" },' +
                         '{ "firstName":"Anna" , "lastName":"Smith" },' +
                         '{ "firstName":"Peter" , "lastName":"Jones" } ]
                       }';
    
             var obj = JSON.parse(text);

  (3) Functions are not allowed in JSON as object values. The JSON.stringify() function will remove any functions from a JavaScript object, both the key and the value

  (4) Stringify a JavaScript Object :
       |-  
               e.g,
                       Imagine we have this object in JavaScript:

                              var obj = { "name":"John", "age":30, "city":"New York"};

                          Use the JavaScript function JSON.stringify() to convert it into a string.

                            var myJSON = JSON.stringify(obj);

  (5) Stringify a JavaScript Array :

       |- 
                     e.g, 
                          Imagine we have this array in JavaScript:

                                  var arr = [ "John", "Peter", "Sally", "Jane" ];

                          Use the JavaScript function JSON.stringify() to convert it into a string.

                                    var myJSON = JSON.stringify(arr);

  (6) In JSON date objects are not allowed. The JSON.stringify() function will convert any dates into strings.

**********************************************************************************************************************************************************************
                                                                    SECTION : 09
**********************************************************************************************************************************************************************

** AJAX :
    |- It stands for Asynchronous JavaScript and XML
    |- It is not a programming language
    |- It uses a combination of :
         (1) A browser built-in XMLHttpRequest object (to request data from a web server)
         (2) JavaScript and HTML DOM (to display or use the data)

    |- The keystone of AJAX is the  " XMLHttpRequest " object.

 (1) AJAX Request TO Server :

         |- To send a request to a server, we use the open() and send() methods of the XMLHttpRequest object:

                   xhttp.open("GET", "ajax_info.txt", true);
                   xhttp.send();

                            or

                  xhttp.open("POST", "ajax_info.txt", true);
                   xhttp.send();
                   

        |- open(method , URL , async)
        |- send()       --> Sends the request to the server (used for GET)
        |- send(string) --> Sends the request to the server (used for POST)


 
     
     
     
     
     
     
     */


}
