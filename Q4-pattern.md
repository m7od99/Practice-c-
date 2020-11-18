The method takes two strings and returns a string represnting their longest common pattern.

Input:  two strings.

Output:  the longest common substring (string)






0-  Initialize a counter. Set it to 0.

0- initialize  a list of int tuples named dic

0-  initialize a bool switch for  "are we counting a pattern currently?"


For each character w in string 2,  for 
 every character in string 1that 
 matches it:

     - while both strings still have 
      characters, keep incrementing the      
      two string indexes, then checking if    
      the two characters match. If yes, 
      increment the counter, else, stop.

      - increment the counter one more 
        time to account for the first 
        character
      
      - add the pair ( w, counter) to dic

      - set counter 0.
    

- now iterate through the dic, the pair 
  with the biggest  counter value  has   
 the starting index of the biggest 
  common substring.   