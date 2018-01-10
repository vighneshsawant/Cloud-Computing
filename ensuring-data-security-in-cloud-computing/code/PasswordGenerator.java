import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Random;

/**

* PasswordGenerator- Class to generate password of 8 character length.
* Passwords will contain at least (1) upper case letter.
* Passwords will contain at least (1) lower case letter.
* Passwords will contain at least (1) number.
* Passwords will contain at least (1) special character.
* Passwords will contain at least (8) characters in length.
*/

public class PasswordGenerator {

/**
* Array to store number characters.
*/
char numberChars[] = "0123456789".toCharArray();

/**
* Array to store lower case characters.
*/
char lowerChars[] = "abcdefghijklmnopqrstuvwxyz".toCharArray();

/**
* Array to store upper case characters.
*/
char upperChars[] = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".toCharArray();

/**
* Array to store special characters.
*/
char otherSpecialChars[] = "`~!@#$%^&*()-_=+[{]}\\|;:'\",<.>/?".toCharArray();

/**
* List contains set of number to get from each array, total of all is the length of password i.e. 8
*/
List <Integer>listForLengthOfPassword = new ArrayList<Integer>();

/**
* Random object to generate the random number to pick up random character from array.
*/
Random random = new Random();

/**
* Final password string object holder list.
*/
List <Character>finalpasswordList;

/**
* Constructor.
*/
public PasswordGenerator(){

listForLengthOfPassword.add(1);
listForLengthOfPassword.add(2);
listForLengthOfPassword.add(2);
listForLengthOfPassword.add(3);
}

/**
* getPassword() creates password by picking random character from each array. Every time it is invoked,
* shuffle the number of character to take from each array dynamically.
* @return string as generated password.
*/
public String getPassword(){

Collections.shuffle(listForLengthOfPassword);
finalpasswordList = new ArrayList<Character>();

for(int t=0;t<listForLengthOfPassword.size();t++){

int numberOfCharPerArray = listForLengthOfPassword.get(t);
for(int z=0;z<numberOfCharPerArray;z++){

if(t == 0){

finalpasswordList.add(numberChars[random.nextInt(10)]);
}else if(t == 1){

finalpasswordList.add(lowerChars[random.nextInt(26)]);
}else if(t == 2){

finalpasswordList.add(upperChars[random.nextInt(26)]);
}


else if(t == 3){

finalpasswordList.add(otherSpecialChars[random.nextInt(32)]);
}

}//end for

}//end for

String password = new String();
Collections.shuffle(finalpasswordList);
for(int s=0;s<finalpasswordList.size();s++){

password += finalpasswordList.get(s);
}
return password;
}

/**
* Generates 100 password for testing.
* @param args
*/
public static void main(String args[]){

PasswordGenerator passwordGenerator = new PasswordGenerator();

//for(int u=0; u<1000; u++)
{

System.out.println(passwordGenerator.getPassword());
}
}

}