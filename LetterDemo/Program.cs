using static System.Console;
class LetterDemo
{
    static void Main()
    {
        // Write your code here
        Letter letter = new Letter;
        CertifiedLetter certifiedLetter = new CertifiedLetter;
    }
}

// Write your classes here
    class public Letter
    {
        public string recipientName { get; set;}
        public string mailedDate { get; set;}
        public override string ToString()
            {
                return this.GetType() + ": " + recipientName + " " + mailedDate;
            }
    }
    class public CertifiedLetter : Letter
    {
        public string TrackingNumber { get; set;}
    }

/*
 * Instructions

Create an application class named LetterDemo that instantiates
 objects of two classes named Letter and CertifiedLetter and 
that demonstrates all their methods.

The classes are used by a company to keep track of letters 
they mail to clients. The Letter class includes 
auto-implemented properties for the Name of the recipient 
and the Date mailed (stored as strings).
Step 2

Next, include a ToString() method that overrides the Object 
class’s ToString() method and returns a string that contains 
the name of the class (using GetType()) and the Letter’s 
data field values.

Create a child class named CertifiedLetter that includes 
an auto-implemented property TrackingNumber (of type string) 
that holds a tracking number for the letter.
*/