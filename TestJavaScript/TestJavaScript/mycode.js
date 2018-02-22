function fun1()
{
    //console.log("Hello");
    //alert("Hi from C#!");
    //prompt("Please enter your age:");
    //var length = 10;

    //for (var i = 0; i < length; i++) {
    //    console.log(i);
    //}

    document.write("<h1>C# Rules!</h1>");

}

function Add()
{
    x = parseFloat(document.getElementById("num1").value);
    y = parseFloat(document.getElementById("num2").value);
    result = x + y; 

    document.getElementById("result").innerHTML = "<h1>" + result + "</h1>"; 

    var array1 = [1,2,3,4,5];

    for (var i = 0; i < array1.length; i++) {
        console.log(array1[i]);
    }

}