using System;
using System.IO;

class Program {
  public static void Main (string[] args) {
    String path = "Numbers.txt";
    String evenFile = "Even.txt";
    String oddFile = "Odd.txt";

    String [] lines; //holds imported file numbers as strings
    lines = File.ReadAllLines(path); //adds string numbers to the lines array
    int [] numbers = new int [lines.Length]; //creates an int array to hold numbers
    int num;

    //loop through all of the numbers
    for (int i = 0; i < lines.Length; i++){
      num = int.Parse(lines[i]); //turn each string number into an int
      numbers[i] = num; //add int num to the numbers array
      
      //if it is an even number
      if(num % 2 == 0){
        //add to even file
        File.AppendAllText(evenFile, num.ToString() + Environment.NewLine);
      }

      //if it is an odd number
      else{
        //add to odd file
        File.AppendAllText(oddFile, num.ToString() + Environment.NewLine);
      }
    }
  }
}