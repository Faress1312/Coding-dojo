/* 
    Given a string,
    return a new string with the duplicates excluded
    Bonus: Keep only the last instance of each character.
    */
const str1 = [a,b,c,A,B,C];
const expected1 = "abcABC";


const str2 = [h,e,l,l,o,o];
const expected2 = "helo";

const str3 = "";
const expected3 = "";

const str4 = [a,a]
const expected4 = "a";

/**
 * De-dupes the given string.
 */

// var expected = {};

function stringDedupe(str) {
    var expected=""
    for (var i = 0; i<str.length; i++) {
        if (expected.indexOf(str[i] == -1)) {
            expected += str[i]
        }
    }
    return expected
}

console.log(stringDedupe("input :",str, "expected" , expected1 , "Result"));
