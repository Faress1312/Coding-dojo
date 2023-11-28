/* 
Parens Valid
Given an str that has parenthesis in it
return whether the parenthesis are valid

Determines whether the parenthesis in the given string are valid.
 * Each opening parenthesis must have exactly one closing parenthesis.
*/
const str1 = "Y(3(p)p(3)r)s";
const expected1 = true;

const str2 = "N(0(p)3";
const expected2 = false;
// Explanation: not every parenthesis is closed.

const str3 = "N(0)t ) 0(k";
const expected3 = false;
// Explanation: because the second ")" is premature: there is nothing open for it to close.

const str4 = "a(b))(c";
const expected4 = false;
// Explanation: same number of opens and closes but the 2nd closing closes nothing.

const str5 = "a)b((c))";
const expected5 = false;
// Explanation: same number of opens and closes but the 2nd closing closes nothing.

function parensValid(str = "") {
    var test =""
    for(var i = 0; i<str.length; i++)
}
function parensValidCount(str=""){
    var count = 0
    for(var i = 0;i<str.length; i++){
        if(str[i]=="(") {
            count++
        }else if (str[i]==")" && count>0){
            count--
        }
    }
    return count === 0
}
function parensValidCount2(str=""){
    var count = 0
    
    for(var i = 0;i<str.length; i++){
        if(str[i]=="(") {
            count++
        }else if (str[i]==")" && count>0){
            count--
        }
    }
    return count === 0
}
parensValid(str1)
parensValid(str2)
parensValid(str3)
parensValid(str4)
parensValid(str5)
console.log(' Input : ${str1} ---- Exêcted : ${expected1 ---->  Result : ${parensValid(str1)}\n');
console.log(' Input : ${str2} ---- Exêcted : ${expected2 ---->  Result : ${parensValid(str2)}\n');
console.log(' Input : ${str3} ---- Exêcted : ${expected3 ---->  Result : ${parensValid(str3)}\n');
console.log(' Input : ${str4} ---- Exêcted : ${expected4 ---->  Result : ${parensValid(str4)}\n');
console.log(' Input : ${str5} ---- Exêcted : ${expected5 ---->  Result : ${parensValid(str5)}\n');