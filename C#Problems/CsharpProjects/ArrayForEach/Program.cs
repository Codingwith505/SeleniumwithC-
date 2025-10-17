
int examAssignments = 5;
String[] student = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregory"];

int[] Sophia = { 90, 86, 87, 98, 100, 94, 90 };
int[] Andrew = { 92, 89, 81, 96, 90,89  };
int[] Emma = [90, 85, 87, 98, 68, 89, 89, 89 ];
int[] Logan = [90, 95, 87, 88, 96,96 ];
int[] Becky =  { 92, 91, 90, 91, 92, 92, 92 };
int[] Chris = { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] Eric = { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] Gregory =  { 91, 91, 91, 91, 91, 91, 91 }; 


int[] currentScore = new int[10];


Console.WriteLine("Student\t\tExam Score Overall Grade Extra Credit");
foreach (String name in student)
{
    if (name == "Sophia")
    {
        currentScore = Sophia;
    }
    else if (name == "Andrew")
    {
        currentScore = Andrew;
    }
    else if (name == "Emma")
    {
        currentScore = Emma;
    }
    else if (name == "Logan")
    {
        currentScore = Logan;
    }

    else if (name == "Becky")
    {
        currentScore = Becky;
    }
    else if (name == "Chris")
    {
        currentScore = Chris;
    }

else if (name == "Eric")
    {
        currentScore = Eric;
    }

else if (name == "Gregory")
    {
        currentScore = Gregory;
    }




    int currentScoreAssignment = 0;
    decimal currentTotalScore = 0;

    int gradedAssignments = 0;
    decimal examScore = 0;
    foreach (int i in currentScore)
    {
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments)
        {
            currentScoreAssignment += i;
            examScore = (decimal)currentScoreAssignment / examAssignments;
        }
        else
        {
            currentScoreAssignment += i / 10;
        }
    }
    
    currentTotalScore = (decimal)currentScoreAssignment / examAssignments;

    String currentAssignmentGradePoint = "";
    if (currentTotalScore >= 97)
    {
        currentAssignmentGradePoint = "A+";
    }
    else if (currentTotalScore >= 93)
    {
        currentAssignmentGradePoint = "A";
    }
    else if (currentTotalScore >= 90)
    {
        currentAssignmentGradePoint = "A-";
    }
    else if (currentTotalScore >= 87)
    {
        currentAssignmentGradePoint = "B+";
    }
    else if (currentTotalScore >= 83)
    {
        currentAssignmentGradePoint = "B";
    }
    else if (currentTotalScore >= 80)
    {
        currentAssignmentGradePoint = "B-";
    }
    else if (currentTotalScore >= 77)
    {
        currentAssignmentGradePoint = "C+";
    }
    else if (currentTotalScore >= 73)
    {
        currentAssignmentGradePoint = "C";
    }
    else if (currentTotalScore >= 70)
    {
        currentAssignmentGradePoint = "C-";
    }
    else if (currentTotalScore >= 67)
    {
        currentAssignmentGradePoint = "D+";
    }
    else if (currentTotalScore >= 63)
    {
        currentAssignmentGradePoint = "D";
    }
    else if (currentTotalScore >= 60)
    {
        currentAssignmentGradePoint = "D-";
    }
    else
    {
       currentAssignmentGradePoint = "F"; 
    }
    
   
    Console.WriteLine($"{name}\t\t{examScore} \t { currentTotalScore}\t{ currentAssignmentGradePoint}");

}
















// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();

