/*
Longest Palindromic Substring 
Given a string, find the longest substring which is palindrome.

Input: Given string :"forgeeksskeegfor", 
Output: "geeksskeeg"

Input: Given string :"Geeks", 
Output: "ee"
*/

/*
brute force

take first char *, 
get each char from the end x, 
if match take second from begining and second from x if equal continue moving until indexes overlap.
We have one palindrom , then repeat from second character whole process *.

find longest of all palindromes found
O(N^2)
n + n -2 + n - 4 + n - 6 .... 1, n + 2(n/2 - 1 + n/2 -2 + n/2 -3)...) = n + 2((n/2*(n/2+1))/2) = n + (a*a(+1)/2) = O(a^2) since a = n/2 -> O(N^2)
*/

