public class Program {


    static void Main(string[] args) {
       Grade();
        }
    public static void Grade() {
                Console.WriteLine("what is your grade score?");
        int GradeScore = int.Parse(Console.ReadLine());
        if(GradeScore>100){
            Console.WriteLine("A+");
            Console.WriteLine("WOW!" + GradeScore + ".....tryhard!");
        }else if(GradeScore>=90){
            Console.WriteLine("A");
            Console.WriteLine("Great job!!!");
        }else if(GradeScore>=80){
            Console.WriteLine("B");
            Console.WriteLine("Keep it up!");
        }else if(GradeScore>=70){
            Console.WriteLine("C");
            Console.WriteLine("Keep trying!");
        }else if(GradeScore>=60){
            Console.WriteLine("D");
            Console.WriteLine("You've got this!");
        }else{
            Console.WriteLine("F");
            Console.WriteLine("You FAILED! GET GOOD NOOB!!!!");
    }
    }
}