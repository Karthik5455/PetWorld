/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Welcome to PetWorld, press enter to contine");
    Console.ReadLine();
    
    string Pet;
    bool condition = false;
    
    do{
    
    Console.WriteLine("We have three different pets Cat, Dog, Rabbit, Enter the type of pet you want:");
    
    Pet = Console.ReadLine();
    
    if(Pet=="Cat"||Pet=="Dog"||Pet=="Rabbit"){
        condition= true;
    };
    
    if(condition==false){
        Console.WriteLine("Invalid Entry, Enter one of the above options, CASE sensitive!!");
    };
   
    }while(condition==false);
    
    Console.WriteLine("Enter a name for your Pet:");
    
    string PetName = Console.ReadLine();
    
    Console.WriteLine("You have chosen "+Pet+" and named it "+PetName);
  
  
  int hunger = 10;
  int happiness = 10;
  int health = 10;
  int action = 0;
  
  
  Console.WriteLine("Please note the guidelines for the actions and choose accordingly");
  Console.WriteLine("Feeding: Decreases hunger, slightly increases health.Playing: Increases happiness, slightly increases hunger.Resting: Improves health, decreases happiness slightly.");
  Console.WriteLine("We will notify you, if stats are critical!!");
  
  do{
     
    string flag1 = "Y"; 
     
      
  do{
    
  Console.WriteLine("Enter an action for your pet for 1 feeding, 2 for playing, 3 for resting, 4 For time pass:");
  
  action = Convert.ToInt32(Console.ReadLine());
  
   flag1 = "Y";
  
  if(hunger>25&&(action==2||action==3)){
      Console.WriteLine("Invalid hunger is increasing > 25, Critical Warning!!!!!!!!!!!!!!!, Feed your pet");
      Console.WriteLine("Pet is not willing to play or rest, You cant pass time");
      flag1="N";
  };
  
  if(happiness<0&&(action==1||action==3)){
       Console.WriteLine("Invalid happiness is deterioting < 0, Critical Warning!!!!!!!!!!!!!!!, Let your pet play");
      Console.WriteLine("Pet is not willing to eat or rest, You cant pass time");
      flag1 = "N";
  };
  
   if(health<0&&(action==2)){
      Console.WriteLine("Invalid Health is deterioting < 0, Critical Warning!!!!!!!!!!!!!!!, Feed or rest your pet");
      Console.WriteLine("Pet is not willing to play, You cant pass time");
      flag1 = "N";
  };
  
  }while(flag1!="Y");
  
  
  switch(action) 
{
  case 1:
         hunger-=5;
         health+=2;
         happiness-=1;
         
    break;
  case 2:
         happiness+=3;
         hunger+=5;
         //condition=false;
    break;

   case 3:
         health+=3;
         happiness-=2;
         hunger+=3;
        // condition=false;
    break;
    
    case 4:
         happiness-=2;
         hunger+=3;
        // condition=false;
    break;
    
  default:
    Console.WriteLine("Invalid");
    break;
}

 Console.WriteLine("Current stats");
 if(health<5&&health>0){
      Console.WriteLine("Health is deterioting < 5, Warning!!!!!!!!!!!!!!!!!!!!!!, Feed or rest your pet");
 };
  if(health<0){
      Console.WriteLine("Health is deterioting < 0, Critical Warning!!!!!!!!!!!!!!!, Feed or rest your pet");
      Console.WriteLine("Pet is not willing to play");
 };
 if(happiness<5&&happiness>0){
      Console.WriteLine("happiness is deterioting < 5, Warning!!!!!!!!!!!!!!!!!, Let your pet play");
 };
  if(happiness<0){
      Console.WriteLine("happiness is deterioting < 0, Critical Warning!!!!!!!!!!!!!!!, Let your pet play");
      Console.WriteLine("Pet is not willing to eat or rest");
 };
 if(hunger>20&&hunger<25){
      Console.WriteLine("Hunger is increasing, Warning!!!!!!!!!!!!!!!!!!!!!!, Feed your pet");
 };
 if(hunger>25){
      Console.WriteLine("hunger is increasing > 25, Critical Warning!!!!!!!!!!!!!!!, Feed your pet");
      Console.WriteLine("Pet is not willing to play or rest");
 };
 Console.WriteLine("Health: "+health+", happiness: "+happiness+", hunger: "+hunger);
 Console.WriteLine("Do you want to continue Y or N");
 
 
 string flag = Console.ReadLine();
 
 if(flag=="N"){
     condition = false;
 }
  }while(condition==true);
  
  }
}
